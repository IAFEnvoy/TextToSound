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

namespace TextToSound {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            using(SpeechSynthesizer synth = new SpeechSynthesizer()) {
                synth.Speak(textBox1.Text);  
            }
        }
    }
}
