using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;


namespace FuenteInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class cCharacter
        {
            public string Charac { get; set; }
            public int Cuant { get; set; }
        }

       

        private void btnExec_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(textDir.Text))
                {
                    String line = sr.ReadToEnd();
                    line = line.ToLower();
                    label1.Text = line;

                    // crear array de caracteres
                    char[] charsRead = new char[line.Length];
                    using (StringReader reader = new StringReader(line))
                    {
                       reader.ReadAsync(charsRead, 0, line.Length);
                    }
                    // Crear diccionario con todos los char y sus valores
                    
                        Dictionary<string, int> dic = new Dictionary<string, int>();
                        int val;
                        foreach (char c in charsRead)
                        {
                            
                            if (dic.TryGetValue(c.ToString(),out val))
                            {
                                dic[c.ToString()] = val + 1;
                            }
                            else
                            {
                                dic.Add(c.ToString(), 1);
                            }
                        }
                        mDataGridView.DataSource = dic.ToList();
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSearchDir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // llamar al metodo para mostrar el dialog box

            openFileDialog1.ShowDialog();

            // Copiar el nombre del directorio

            textDir.Text = openFileDialog1.FileName.ToString();
        }

        
    }
}
