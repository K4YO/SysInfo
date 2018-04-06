using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace TP_ARQUITETURA
{
    public partial class Form1 : MetroForm
    {
        List<Disco> storage = new List<Disco>();
        Disco disks = new Disco();
        Processador proc = new Processador();
        Memoria ram = new Memoria();
        public Form1()
        {
            InitializeComponent();

            disks.GetInfoDisk(ref storage);
            InsertInfoListStorage(ref metroListViewStorage, storage);

            txt_proc_l1.Text = Convert.ToString(proc.L1Cache);
            txt_proc_l2.Text = Convert.ToString(proc.L2Cache);
            txt_proc_l3.Text = Convert.ToString(proc.L3Cache);
            txt_proc_log.Text = Convert.ToString(proc.ProcessadoresLogicos);
            txt_proc_modelo.Text = proc.Nome;
            txt_prox_nuc.Text = Convert.ToString(proc.Nucleos);
            txt_proc_arq.Text = proc.Arquitetura;
            txt_proc_freqmax.Text = proc.FrequeciaMaxima;

            txt_ram_bar.Text = ram.TipoMemoria;
            txt_ram_freq.Text = ram.Frequecia;
            txt_ram_Clock.Text = ram.FrequeciaClock;
            txt_ram_volts.Text = ram.MaxVoltage;           
            txt_ram_total.Text = ram.CapacidadeTotal;
           
       
        }
        
        private void InsertInfoListStorage(ref MetroListView lst, List<Disco> storage)
        {
            lst.Items.Clear();
            ListViewGroup grp;
            string[] Texts = { "DeviceID", "Nome Unidade", "Rótulo", "Tipo Partição", "Tipo Disco", "Capacidade Total", "Capacidade Utilizada", "Capacidade Livre" };
            string[] Properties = { "DeviceID", "NomeUnidade", "Rotulo", "TipoParticao", "TipoDisco", "CapacidadeTotal", "CapacidadeUilizada", "CapacidadeLivre" };
            try
            {
                foreach (Disco disk in storage)
                {
                    grp = lst.Groups.Add(disk.Nome.ToString(), disk.Nome.ToString());

                    for (int i = 0; i < Texts.Length; i++)
                    {
                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else item.BackColor = Color.WhiteSmoke;
                        item.Text = Texts[i];
                        item.SubItems.Add(disk.GetProperties(Properties[i]));
                        lst.Items.Add(item);

                    }
                   
                }
            
            }


            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float percentCPUInUse = proc.PercentUso();
            float percentMemoryInUse = ram.PercentUso();

           
            txt_ram_livre.Text = ram.CapacidadeLivre();
            txt_ram_uso.Text = ram.CapacidadeUtilizada();
            circularProgressBarCPU.Value = (int)percentCPUInUse; // adiciona a porcentagem do CPU em uso ao valor (gráfico) da barra
            circularProgressBarCPU.Text = string.Format("{0:0.00}%", percentCPUInUse);
            circularProgressBarMemory.Value = (int)percentMemoryInUse; // adiciona a porcentagem da memória primária ao valor (gráfico) da barra
            circularProgressBarMemory.Text = string.Format("{0:0.00}%", percentMemoryInUse);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 formInformation = new Form2();
            formInformation.Show();
        }

     
    }
}
