using AgeOfVillagers.Open;
using AgeOfVillagers.Save;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public string selected_nation = "";
        public string selected_component = "";
        Village vill;

        INation nation;

        public VillageWindow()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e) { }

        private void SidePanel_Paint(object sender, PaintEventArgs e) { }

        private void btn_house_Click(object sender, EventArgs e)
        {
            selected_component = "house";
        }

        private void btn_tree_Click(object sender, EventArgs e)
        {
            selected_component = "tree";
        }

        private void btn_waterSource_Click(object sender, EventArgs e)
        {
            selected_component = "water_source";
        }

        private void btn_saveVillage_Click(object sender, EventArgs e)
        {
            SaveVillage sv = new SaveVillage(vill);
            sv.SaveFile();
        }

        private void btn_openVillage_Click(object sender, EventArgs e)
        {
            btn_newVillage_Click(this, e);
            OpenVillage ov = new OpenVillage();
            vill = ov.getVill();
            vill.nation = selected_nation;
            if (selected_nation == "Arab Bedouins")
            {
                vill.rivers_drawn = null;
            }
            if (selected_nation == "Inuit Hunters")
            {
                vill.rivers_drawn = null;
                vill.trees_drawn = null;
            }
            setSavedVill(vill);
        }

        private void btn_newVillage_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
            g.Clear(DrawingPanel.BackColor);
            vill = new Village();
            Label_villName.Text = "Untitled";
            selected_nation = "";
            selected_component = "";
        }


        public void SaveState(string selected_component, string selected_nation, Point p)
        {
            vill.nation = selected_nation;
            if (selected_component == "tree")
            {
                vill.trees_drawn.Add(p);
            }
            if (selected_component == "house")
            {
                vill.houses_drawn.Add(p);
            }
            if (selected_component == "water_source")
            {
                vill.rivers_drawn.Add(p);
            }
        }

        public void setSavedVill(Village vill)
        {
            selected_nation = vill.nation;
            if (selected_nation == "Arab Bedouins")
            {
                nation = new Arab();
            }
            else if (selected_nation == "Bangladeshi Farmers")
            {
                nation = new Bangladesh();
            }
            else if (selected_nation == "Egyptian Kings")
            {
                nation = new Egypt();
            }
            else if (selected_nation == "Inuit Hunters")
            {
                nation = new Inuit();
            }
            else
            {
                nation = null;
            }
            if(nation != null) g.Clear(nation.getBackgroundColor());

            Label_villName.Text = vill.village_name;
            foreach (Point p in vill.trees_drawn.ToList())
            {
                selected_component = "tree";
                drawInPanel(p);
            }
            foreach (Point p in vill.houses_drawn.ToList())
            {
                selected_component = "house";
                drawInPanel(p);
            }
            foreach (Point p in vill.rivers_drawn.ToList())
            {
                selected_component = "water_source";
                drawInPanel(p);
            }
            nation_selector.SelectedIndex = nation_selector.Items.IndexOf(vill.nation);
        }

        // control func
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        private void nation_selector_SelectedIndexChanged(object sender, EventArgs e)
        {

            selected_nation = nation_selector.Text;
            if (selected_nation == "Arab Bedouins")
            {
                nation = new Arab();
            }
            else if (selected_nation == "Bangladeshi Farmers")
            {
                nation = new Bangladesh();
            }
            else if (selected_nation == "Egyptian Kings")
            {
                nation = new Egypt();
            }
            else if (selected_nation == "Inuit Hunters")
            {
                nation = new Inuit();
            }
            else
            {
                nation = null;
            }
            g.Clear(nation.getBackgroundColor());
            vill = new Village();
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;
            drawInPanel(p);
        }
        public void drawInPanel(Point p)
        {
            if (selected_nation.Length == 0 || selected_component.Length == 0)
            {
                MessageBox.Show("Select nation and component to draw");
            }
            else
            {
                IComponent component;
                component = nation.getComponent(selected_component);
                component.draw(p, g, pen);
                SaveState(selected_component, selected_nation, p);
            }
        }

        private void Label_villName_Click(object sender, EventArgs e)
        {

        }
    }
}