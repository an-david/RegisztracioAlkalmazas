using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        static List<Ugyfel> Ugyfelek = new List<Ugyfel>();

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            string Nev = textBox_Nev.Text.Trim();
            string SzulDatum = textBox_SzulDatum.Text.Trim();
            string KedvencHobbi = label_KivalasztottHobbi.Text.Trim();

            if (String.IsNullOrEmpty(Nev))
            {
                MessageBox.Show("Név mező kitöltése kötelező!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(SzulDatum))
            {
                MessageBox.Show("Születési dátum mező kitöltése kötelező!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(radioButton_Ferfi.Checked || radioButton_No.Checked))
            {
                MessageBox.Show("Nem választása kötelező!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(listBox_Hobbik.Items.Count > 0))
            {
                MessageBox.Show("Hobbi felvétele kötelező!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(KedvencHobbi)) 
            {
                MessageBox.Show("Válassza ki a listából a kedvenc hobbiját!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!helyesSzulDatum(SzulDatum))
            {
                MessageBox.Show("Érvénytelen Születési dátum!", "Érvénytelen adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Hobbik = "";
                string Nem = radioButton_Ferfi.Checked ? Nem = "Férfi" : Nem = "Nő";

                for (int i = 0; i < listBox_Hobbik.Items.Count; i++)
                {
                    Hobbik += listBox_Hobbik.Items[i];
                    if (i + 1 < listBox_Hobbik.Items.Count)
                    {
                        Hobbik += ", ";
                    }
                }

                Ugyfel ugyfel = new Ugyfel(Nev, SzulDatum, Nem, Hobbik, KedvencHobbi);
                Ugyfelek.Add(ugyfel);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Ugyfel item in Ugyfelek.ToArray())
                        {
                            sw.WriteLine(item.kiIratas());
                        }
                    }
                }

                textBox_Nev.Clear();
                textBox_SzulDatum.Clear();
                textBox_UjHobbi.Clear();
                listBox_Hobbik.Items.Clear();
                label_KivalasztottHobbi.Text = "";
                radioButton_Ferfi.Checked = false;
                radioButton_No.Checked = false;
            }
        }

        private void button_HobbiHozzaad_Click(object sender, EventArgs e)
        {
            string Hobbi = textBox_UjHobbi.Text.Trim();
            if (String.IsNullOrEmpty(Hobbi))
            {
                MessageBox.Show("Nem adott meg új hobbit!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                bool duplicate = false;

                if (listBox_Hobbik.Items.Count > 0)
                {
                    for (int i = 0; i < listBox_Hobbik.Items.Count; i++)
                    {
                        if (listBox_Hobbik.Items[i].Equals(Hobbi))
                        {
                            MessageBox.Show("Már létezik ilyen hobbi!", "Ismétlő adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            duplicate = true;
                            break;
                        }
                    }
                }

                if (!duplicate)
                {
                    listBox_Hobbik.Items.Add(Hobbi);
                    textBox_UjHobbi.Clear();
                }
            }
        }

        private void listBox_Hobbik_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_KivalasztottHobbi.Text = listBox_Hobbik.Items[listBox_Hobbik.SelectedIndex].ToString();
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    Ugyfel ugyfel = null;
                    while (!sr.EndOfStream)
                    {
                        ugyfel = new Ugyfel(sr.ReadLine());
                    }
                    textBox_Nev.Text = ugyfel.Nev;
                    textBox_SzulDatum.Text = ugyfel.SzulDatum;
                    label_KivalasztottHobbi.Text = ugyfel.KedvencHobbi;

                    string[] hobbik = ugyfel.Hobbi.Split(',');
                    foreach (string hobbi in hobbik)
                    {
                        listBox_Hobbik.Items.Add(hobbi.Trim());
                    }

                    if (ugyfel.Nem.Equals("Férfi"))
                    {
                        radioButton_Ferfi.Checked = true;
                    } else
                    {
                        radioButton_No.Checked = true;
                    }

                }
            }
        }

        private bool helyesSzulDatum(string SzulDatum)
        {
            string[] datum = SzulDatum.Split('.');
            int[] _31NaposHonapok = { 1, 3, 5, 7, 8, 10, 12 };
            int[] _30NaposHonapok = { 4, 6, 9, 11 };

            int ev = 0;
            int honap = 0;
            int nap = 0;

            try
            {
                ev = Convert.ToInt32(datum[0]);
                honap = Convert.ToInt32(datum[1]);
                nap = Convert.ToInt32(datum[2]);
            } catch {}

            foreach (int i in _31NaposHonapok)
            {
                if (i == honap && (nap > 31 || nap <= 0))
                {
                    return false;
                }
            }

            foreach (int i in _30NaposHonapok)
            {
                if (i == honap && (nap > 30 || nap <= 0))
                {
                    return false;
                }
            }

            if (ev >= DateTime.Now.Year || datum.Length != 3 || honap > 12)
            { 
                return false;
            } else if (honap == 2 && (nap > 29 || nap <= 0)) {
                return false;
            }


            return true;
        }
    }
}
