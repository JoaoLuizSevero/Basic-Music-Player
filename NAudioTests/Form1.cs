using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using NAudio.Midi;

namespace NAudioTests
{
    public partial class Form1 : Form
    {
        private AudioFileReader stream = null;
        private WaveOutEvent output = null;
        private MonoToStereoSampleProvider stereo = null;
        private SmbPitchShiftingSampleProvider pitch = null;
        private WaveInEvent waveIn = new WaveInEvent();
        private WaveFileWriter writer = null;
        private WasapiLoopbackCapture capture = null;
        private WaveOutEvent wo = null;

        bool closing = false;

        delegate void RecordingStoppedEventHandler(object source, EventArgs e);

        public Form1()
        {
            InitializeComponent();
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 1;


            List<string> waves = new List<string>();
            waves.Add("Sin");
            waves.Add("Triangle");
            waves.Add("Square");
            waves.Add("SawTooth");
            waves.Add("PinkNoise");
            waves.Add("WhiteNoise");
            waves.Add("Sweep");
            cb_waves.DataSource = waves;
            vsb_volumeL.Value = 50;
            lb_volumeL.Text = "50";
            lb_volumeR.Text = "50";
            lb_volumeM.Text = "50";
            btn_stop.Enabled = false;
            btn_pause.Enabled = false;
            trb_progress.Enabled = false;
            vsb_volumeL.Enabled = false;
            vsb_volumeR.Enabled = false;
            vsb_volumeM.Enabled = false;
            cb_controle.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (comboBox1.SelectedItem != null)
                {
                    var device = (NAudio.CoreAudioApi.MMDevice)comboBox1.SelectedItem;

                    if ((int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100)) < progressBar1.Maximum)
                    {
                        progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                    }
                    else
                    {
                        progressBar1.Value = progressBar1.Maximum;
                    }
                    if ((int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 100)) < progressBar2.Maximum)
                    {
                        progressBar2.Value = (int)(Convert.ToSingle(device.AudioMeterInformation.PeakValues[0].ToString()) * 100);
                    }
                    else
                    {
                        progressBar2.Value = progressBar2.Maximum;
                    }
                    if ((int)(Math.Round(device.AudioMeterInformation.PeakValues[1] * 100)) < progressBar3.Maximum)
                    {
                        progressBar3.Value = (int)(Convert.ToSingle(device.AudioMeterInformation.PeakValues[1].ToString()) * 100);
                    }
                    else
                    {
                        progressBar3.Value = progressBar3.Maximum;
                    }
                    if (((progressBar2.Value / 3) + progressBar3.Value) < progressBar4.Maximum)
                    {
                        progressBar4.Value = (progressBar2.Value / 3) + progressBar3.Value;
                    }
                    else
                    {
                        progressBar4.Value = progressBar4.Maximum;
                    }
                    progressBar6.Value = progressBar3.Value;
                    progressBar7.Value = progressBar1.Value;
                    progressBar8.Value = progressBar2.Value;
                }

                trb_progress.Value = (int)stream.CurrentTime.TotalSeconds;

                if (stream.CurrentTime.ToString().Length > 8)
                {
                    lb_decTime.Text = stream.CurrentTime.ToString().Remove(8);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
            if (pitch != null)
            {
                pitch = null;
            }
            if (stereo != null)
            {
                stereo = null;
            }
            closing = true;
            if (capture != null && capture.CaptureState == NAudio.CoreAudioApi.CaptureState.Capturing)
            {
                capture.StopRecording();
            }
            if (wo != null)
            {
                if (wo.PlaybackState == PlaybackState.Playing)
                {
                    wo.Stop();
                }
                wo.Dispose();
            }
            waveIn.StopRecording();
            writer?.Dispose();
            wo = null;
            waveIn = null;
            capture = null;
            writer = null;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "MP3 File (*.mp3)|*.mp3|WAV File (*.wav)|*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;

            output = new WaveOutEvent();
            stream = new AudioFileReader(open.FileName);
            pitch = new SmbPitchShiftingSampleProvider(stream.ToSampleProvider());

            pitch.PitchFactor = 1;
            stereo = new MonoToStereoSampleProvider(pitch.ToMono());

            output.Init(stereo);

            stereo.RightVolume = 0.5f;
            stereo.LeftVolume = 0.5f;
            stream.Volume = 0.5f;

            lb_name.Text = open.SafeFileName;
            lb_length.Text = stream.TotalTime.ToString().Remove(8);
            lb_length.Text += " sec.";
            lb_decTime.Text = stream.CurrentTime.ToString();

            btn_pause.Enabled = true;
            btn_stop.Enabled = true;
            vsb_volumeL.Enabled = true;
            vsb_volumeM.Enabled = true;
            vsb_volumeR.Enabled = true;
            trb_progress.Enabled = true;
            cb_controle.Enabled = true;

            trb_progress.Maximum = (int)stream.TotalTime.TotalSeconds;

        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                    btn_pause.Text = "Play";
                }
                else
                {
                    output.Play();
                    btn_pause.Text = "Pause";
                }
            }
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                btn_stop.Enabled = false;
                btn_pause.Enabled = false;
                vsb_volumeL.Enabled = false;
                vsb_volumeR.Enabled = false;
                vsb_volumeM.Enabled = false;
                trb_progress.Enabled = false;
                cb_controle.Enabled = false;
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;
                progressBar6.Value = 0;
                progressBar7.Value = 0;
                progressBar8.Value = 0;
                btn_pause.Text = "Play";
                lb_name.Text = "";
                lb_length.Text = "";
                trb_progress.Value = 0;
                lb_decTime.Text = "";

                if (output != null)
                {
                    if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    {
                        output.Stop();
                    }
                    output.Dispose();
                    output = null;
                }
                if (stream != null)
                {
                    stream.Dispose();
                    stream = null;
                }
                if (pitch != null)
                {
                    pitch = null;
                }
                if (stereo != null)
                {
                    stereo = null;
                }
            }
        }

        private void trb_progress_Scroll(object sender, EventArgs e)
        {
            TimeSpan T = new TimeSpan(trb_progress.Value * 10000000);
            stream.CurrentTime = T;
        }
        private void vsb_volumeR_Scroll(object sender, ScrollEventArgs e)
        {
            if (output != null)
            {
                stereo.RightVolume = Convert.ToSingle(vsb_volumeR.Value) / 100;
            }
            lb_volumeR.Text = vsb_volumeR.Value.ToString();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (output != null)
            {
                stereo.LeftVolume = Convert.ToSingle(vsb_volumeL.Value) / 100;
            }
            lb_volumeL.Text = vsb_volumeL.Value.ToString();
        }
        private void vsb_volumeM_Scroll(object sender, ScrollEventArgs e)
        {
            if (output != null)
            {
                stream.Volume = Convert.ToSingle(vsb_volumeM.Value) / 100;
            }
            lb_volumeM.Text = vsb_volumeM.Value.ToString();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cb_controle.Checked == true)
            {
                vsb_volumeL.Value = 100 - ((e.X * 10) / 15);
                vsb_volumeR.Value = (e.X * 10) / 15;
                vsb_volumeM.Value = 100 - e.Y;
                lb_volumeL.Text = vsb_volumeL.Value.ToString();
                lb_volumeR.Text = vsb_volumeR.Value.ToString();
                lb_volumeM.Text = vsb_volumeM.Value.ToString();
                stereo.LeftVolume = Convert.ToSingle(vsb_volumeL.Value) / 100;
                stereo.RightVolume = Convert.ToSingle(vsb_volumeR.Value) / 100;
                stream.Volume = Convert.ToSingle(vsb_volumeM.Value) / 100;
            }
        }
        private void trb_pitch_Scroll(object sender, EventArgs e)
        {
            switch (trb_pitch.Value)
            {
                case -2:
                    pitch.PitchFactor = (float)Globals.downTwoTone;
                    break;
                case - 1:
                    pitch.PitchFactor = (float)Globals.downOneTone;
                    break;
                case 0:
                    pitch.PitchFactor = 1;
                    break;
                case 1:
                    pitch.PitchFactor = (float)Globals.upOneTone;
                    break;
                case 2:
                    pitch.PitchFactor = (float)Globals.upTwoTone;
                    break;
                default:
                    pitch.PitchFactor = 1;
                    break;
            }
        }
        private void cb_controle_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_controle.Checked == true)
            {
                pictureBox1.Cursor = Cursors.NoMove2D;
            }
            else
            {
                pictureBox1.Cursor = Cursors.Default;
            }
        }

        private void btn_playWave_Click(object sender, EventArgs e)
        {
            btn_playWave.Enabled = false;
            btn_stopWave.Enabled = true;
            SignalGenerator wave = null;
            switch (cb_waves.SelectedIndex)
            {
                case 0:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.Sin,
                    };
                    break;
                case 1:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.Triangle,
                    };
                    break;
                case 2:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.Square,
                    };
                    break;
                case 3:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.SawTooth,
                    };
                    break;
                case 4:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.Pink,
                    };
                    break;
                case 5:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.White,
                    };
                    break;
                case 6:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        FrequencyEnd = 2000,
                        SweepLengthSecs = 2,
                        Type = SignalGeneratorType.Sweep,
                    };
                    break;
                default:
                    wave = new SignalGenerator()
                    {
                        Gain = 0.2,
                        Frequency = 500,
                        Type = SignalGeneratorType.Sin,
                    };
                    break;
            }
            MidiEvent midi = new MidiEvent(100000, 1, MidiCommandCode.NoteOn);

            wo = new WaveOutEvent();
            wo.Init(wave);
            wo.Play();
        }
        private void btn_stopWave_Click(object sender, EventArgs e)
        {
            btn_playWave.Enabled = true;
            btn_stopWave.Enabled = false;
            wo.Stop();
            wo.Dispose();
            wo = null;
        }

    }
}
