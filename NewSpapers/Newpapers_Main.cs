using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSpapers
{
    public partial class Newpapers : System.Windows.Forms.Form
    {
        Model1 db = new Model1();
        List<Filtr> filtrList = new List<Filtr>();//коллекция для фильтрации
        public static bool add;
        public Newpapers()
        {
            InitializeComponent();
        }

        public void FullTable()
        {
            agentBindingSource.DataSource = db.Agent.ToList();//заполняем данные в таблицу из бд
            agentTypeBindingSource.DataSource = db.AgentType.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FullTable();
            //заполнение коллекции
            filtrList = db.AgentType.Select(f => new Filtr { id = f.ID, typeOfProd = f.Title }).ToList();
            //вставка первой строки
            filtrList.Insert(0, new Filtr { id = 0, typeOfProd = "Все типы" });
            //добавление данных в комбобокс из коллекции
            filtrCmb.DataSource = filtrList;
            filtrCmb.DisplayMember = "typeOfProd";//то, что показывается пользователю
            filtrCmb.ValueMember = "id";//то, с чем мы работаем
        }
        private void AgentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Agent prod = (Agent)agentBindingSource.Current;
            if (prod.Logo != "NULL")
            {
                string s = prod.Logo;
                string folder = s;
                imageProdPic.Image = Image.FromFile(folder);
            }
            else
            {
                imageProdPic.Image = Image.FromFile("products\\фон.png");
            }

        }
        
        private void FiltrCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (filtrCmb.SelectedIndex < 0)
                return;
            if (filtrCmb.SelectedIndex == 0)
            {
                FullTable();
            }
            else
            {
                int n = (int)filtrCmb.SelectedValue;
                agentBindingSource.DataSource = db.Agent.Where(p => p.AgentTypeID == n).ToList();
            }

        }
        public class Filtr
        {
            public int id { get; set; }
            public string typeOfProd { get; set; }
        }

        

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            Agent prod = (Agent)agentBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить продукцию - {prod.Title.ToString()}?",
                "Удаление продукции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Agent.Remove(prod);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Внимание! Продукция успешно удалена!", "Успешное удаление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }

        private void sortCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sortCmb.SelectedIndex == 0)
            {
                agentBindingSource.DataSource = db.Agent.OrderBy(p => p.AgentTypeID).ToList();
            }
            else if (sortCmb.SelectedIndex == 1)
            {
                agentBindingSource.DataSource = db.Agent.OrderByDescending(p => p.AgentTypeID).ToList();
            }
            else if (sortCmb.SelectedIndex == 2)
                agentBindingSource.DataSource = db.Agent.OrderBy(p => p.Priority).ToList();
            else if (sortCmb.SelectedIndex == 3)
                agentBindingSource.DataSource = db.Agent.OrderByDescending(p => p.Priority).ToList();            
                
            else if (sortCmb.SelectedIndex == 4)
            {
                agentTypeBindingSource.DataSource = db.AgentType.ToList();
                agentBindingSource.DataSource = db.Agent.ToList();//заполняем данные в таблицу из бд
            }
            //
        }

        private void changeProdBtn_Click(object sender, EventArgs e)
        {
            add = false;
            Agent prod = (Agent)agentBindingSource.Current;
            Newpapers_Redit acp = new Newpapers_Redit();
            acp.db = db;
            acp.prod = prod;
            DialogResult dr = acp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }
    }
}
