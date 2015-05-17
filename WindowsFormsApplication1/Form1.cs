
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<OutlookStorage.Message> messages = new List<OutlookStorage.Message>();
        OutlookStorage.Message msgEnCours = null;

        public Form1()
        {
            InitializeComponent();
            cmb_categ.SelectedIndex = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Outlook Message Mail (.msg)|*.msg";
            ofd.FilterIndex = 1;

            ofd.Multiselect = true;

            // Process input if the user clicked OK.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofd.FileNames)
                {
                    OutlookStorage.Message newMessage = new OutlookStorage.Message(file);
                    messages.Add(newMessage);

                }
            }
            listBox1.DataSource = null;
            listBox1.DataSource = messages;

            try
            {
                listBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OutlookStorage.Message msg = messages[listBox1.SelectedIndex];

                lbl_emetteur.Text = "De : " + msg.From;
                lbl_objet.Text = "Objet : " + msg.Subject;
                txt_corps.Text = msg.BodyText;

                string rec = "";

                foreach (OutlookStorage.Recipient rcp in msg.Recipients)
                {
                    rec += rcp.Email + " ; ";
                }

                listPJ.Items.Clear();

                foreach (OutlookStorage.Attachment att in msg.Attachments)
                {
                    string extension = att.Filename.Substring(att.Filename.IndexOf('.'));
                    int imageIndex = 0;
                    switch (extension)
                    {
                        case ".doc":
                            imageIndex = 16;
                            break;

                        case ".docx":
                            imageIndex = 16;
                            break;

                        case ".xlsx":
                            imageIndex = 15;
                            break;

                        case ".xls":
                            imageIndex = 15;
                            break;

                        case ".csv":
                            imageIndex = 15;
                            break;

                        case ".ppt":
                            imageIndex = 28;
                            break;

                        case ".pptx":
                            imageIndex = 28;
                            break;

                        case ".pdf":
                            imageIndex = 11;
                            break;

                        default:
                            imageIndex = 12;
                            break;
                    }
                    listPJ.Items.Add(att.Filename, imageIndex);

                }

                msgEnCours = msg;


                rec = rec.Remove(rec.Length - 3);
                lbl_destinataire.Text = rec;

                
       
            }
            catch(Exception ex)
            {

            }
            
            
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            List<OutlookStorage.Message> msgListRech = new List<OutlookStorage.Message>();
            listBox1.DataSource = null;

            switch(cmb_categ.SelectedIndex)
            {
                case 0: //cas émetteur

                    foreach(OutlookStorage.Message msg in messages)
                    {
                        if(msg.From.Contains(txt_recherche.Text))
                        {
                            msgListRech.Add(msg);
                        }
                    }

                    break;

                case 1: //cas destinataire

                    foreach (OutlookStorage.Message msg in messages)
                    {
                        bool ok = false;
                        foreach (OutlookStorage.Recipient rcp in msg.Recipients)
                        {
                            if (rcp.Email.Contains(txt_recherche.Text))
                            {
                                ok = true;
                            }
                        }
                        if (ok == true)
                        {
                            msgListRech.Add(msg);
                        }
                    }

                    break;

                case 2: //cas objet

                    foreach(OutlookStorage.Message msg in messages)
                    {
                        if(msg.Subject.Contains(txt_recherche.Text))
                        {
                            msgListRech.Add(msg);
                        }
                    }

                    break;

                case 3: //cas corps

                    foreach(OutlookStorage.Message msg in messages)
                    {
                        if(msg.BodyText.Contains(txt_recherche.Text))
                        {
                            msgListRech.Add(msg);
                        }
                    }

                    break;
                }
            listBox1.DataSource = msgListRech;
        }

        private void cmb_categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_recherche.Text = "";
        }
        public bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(_FileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}",
                                  _Exception.ToString());
            }

            // error occured, return false
            return false;
        }

        private void listPJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPJ_DoubleClick(object sender, EventArgs e)
        {
            string _FileName = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\" + msgEnCours.Attachments[listPJ.SelectedIndices[0]].Filename;
            byte[] _ByteArray= msgEnCours.Attachments[listPJ.SelectedIndices[0]].Data;
            ByteArrayToFile(_FileName, _ByteArray);
            System.Diagnostics.Process.Start(_FileName);
        }

        private void btn_voice_Click(object sender, EventArgs e)
        {
            
            ThreadStart job = new ThreadStart(() =>
            {
                string toSpeech = "email de. " + msgEnCours.From + "." + "Objet du message. " + msgEnCours.Subject + "Corps du message." + msgEnCours.BodyText;
                SpeechSynthesizer syn = new SpeechSynthesizer();
                syn.Speak(toSpeech);
            });

            Thread t = new Thread(job);
            t.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_splash.Visible = false;
            timer1.Enabled = false;
        }
    }

}

