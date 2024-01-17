using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.AudioFormat;


namespace speechProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            reader.SpeakAsync(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var voice = comboBox1.SelectedItem as String;
            if (voice != null)

            {
                reader.SelectVoice(voice);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        
        {
            PopulateInstalledVoices();
        }
        
        private SpeechSynthesizer reader = new SpeechSynthesizer();
        private void PopulateInstalledVoices()

        {
            foreach (InstalledVoice voice in reader.GetInstalledVoices())

            {
                VoiceInfo info = voice.VoiceInfo;

                comboBox1.Items.Add(info.Name);
            }
        }
    }
    }
    

