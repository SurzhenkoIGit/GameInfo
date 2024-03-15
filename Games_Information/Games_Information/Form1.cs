using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesContext;
using MetaGames;

namespace Games_Information
{
    public partial class Form1 : Form
    {
        GameContext gc;
        public Form1()
        {
            InitializeComponent();
            gc = new GameContext();
            gc.Games.Load();
            dataGridView1.DataSource = gc.Games.Local.ToBindingList();
            
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txb_title.Text != "" && txb_creator.Text != "")
            { 
                var t_c = gc.Games.Where(x => x.Title == txb_title.Text && x.Creator == txb_creator.Text);
                //dataGridView1.DataSource = null;
                dataGridView1.DataSource = t_c.ToList();
                return;
            }
            if (txb_title.Text != "")
            {
                var title = gc.Games.Where(x => x.Title == txb_title.Text);
                dataGridView1.DataSource = title.ToList();
                return;
            }
            if(txb_genre.Text != "")
            {
                var genre = gc.Games.Where(x => x.Genre == txb_genre.Text);
                dataGridView1.DataSource = genre.ToList();
                return;
            }
            if(txb_release.Text != "")
            {
                var release = gc.Games.Where(x => x.Release == txb_release.Text);
                dataGridView1.DataSource = release.ToList();
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_title.Text = string.Empty;
            txb_creator.Text = string.Empty;
            txb_genre.Text = string.Empty;
            txb_release.Text = string.Empty;

            dataGridView1.DataSource = gc.Games.Local.ToBindingList();
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            DialogResult res = add.ShowDialog(this);

            if(res == DialogResult.OK)
            {
                Game game = new Game()
                { 
                    Title = add.txb_Title.Text,
                    Creator = add.txb_Creator.Text,
                    Genre = add.cmb_Genre.SelectedItem.ToString(),
                    Release = add.txb_Release.Text,
                    GameMode = add.cmb_GameMode.SelectedItem.ToString(),
                    Count = (int)add.nud_Count.Value
                };

                gc.Games.Add(game);
                gc.SaveChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (convert == false)
                    return;

                Game game = gc.Games.Find(id);

                AddForm add = new AddForm();

                add.txb_Title.Text = game.Title;
                add.txb_Creator.Text = game.Creator;
                add.cmb_Genre.SelectedItem = game.Genre;
                add.txb_Release.Text = game.Release;
                add.cmb_GameMode.SelectedItem = game.GameMode;
                add.nud_Count.Value = game.Count;
                

                DialogResult res = add.ShowDialog(this);

                if (res == DialogResult.Cancel)
                    return;

                game.Title = add.txb_Title.Text;
                game.Creator = add.txb_Creator.Text;
                game.Genre = add.cmb_Genre.SelectedItem.ToString();
                game.Release = add.txb_Release.Text;
                game.GameMode = add.cmb_GameMode.SelectedItem.ToString();
                game.Count = (int)add.nud_Count.Value;

                gc.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Объект обновлен!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить?");
                if (res == DialogResult.OK)
                { 
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (convert == false)
                        return;



                    Game game = gc.Games.Find(id);
                    gc.Games.Remove(game);
                    gc.SaveChanges();
                }
                MessageBox.Show("Объект удален!");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gamemode(string version)
        {
            var mode = gc.Games.Where(x => x.GameMode == version);
            dataGridView1.DataSource = mode.ToList();
        }

        private void одиночныеИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamemode("Singleplayer");
        }

        private void мультиплеерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamemode("Multiplayer");
        }

        private void btn_buh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gc.Games.Local.ToBindingList();
        }        

        private void большеВсегоПроданныхКопийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = gc.Games.Max(x => x.Count);
            var res = gc.Games.Where(x => x.Count == max);

            dataGridView1.DataSource = res.ToList();

        }

        private void меньшеВсегоПроданныхКопийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = gc.Games.Min(x => x.Count);
            var res = gc.Games.Where(x => x.Count == min);

            dataGridView1.DataSource = res.ToList();
        }

        private void топ3СамыхПродаваемыхИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = gc.Games.GroupBy(x => x.Title).OrderByDescending(gc => gc.Count()).Take(3);

            dataGridView1.DataSource = list.ToList();
        }

        private void топ3СамыхНепродаваемыхИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = gc.Games.GroupBy(x => x.Title).OrderBy(gc => gc.Count()).Take(3);

            dataGridView1.DataSource = list.ToList();
        }
    }
}
