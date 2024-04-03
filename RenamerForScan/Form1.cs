using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RenamerForScan
{
    public partial class Form1 : Form
    {
        private ListBox listBox1;

        private Panel panel1;

        private PictureBox pictureBox1;

        private TextBox textBox1;

        private Button button1;

        private Button button2;

        private Button button3;

        private CheckBox checkBox1;

        private Label label1;
        private string dir;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            //
            // listBox1
            //
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(4, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 855);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(327, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 702);
            this.panel1.TabIndex = 1;
            //
            // pictureBox1
            //
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 702);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            //
            // textBox1
            //
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(406, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 30);
            this.textBox1.TabIndex = 2;
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(506, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "リネーム開始⏎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(4, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "リスト更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(144, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "リスト消去";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // checkBox1
            //
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(677, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 40);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "000a形式";
            this.checkBox1.UseVisualStyleBackColor = true;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ノンブル";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "RenamerForScan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String buff = textBox1.Text;
            bool canConvert = int.TryParse(buff, out _);
            if (!canConvert)
                return;
            int num = int.Parse(textBox1.Text) + (listBox1.Items.Count - listBox1.SelectedIndex - 1);
            int maxDigits = Math.Max(3, (int)Math.Log10(num) + 1);
            checkname();
            string text = "";
            string text2 = "";
            string text3 = "";
            int num2 = num;
            int num3 = -1;
            for (int num4 = listBox1.Items.Count - 1; num4 >= 0; num4--)
            {
                text2 = dir + "\\" + listBox1.Items[num4].ToString();
                text = new FileInfo(text2).Extension;
                text3 = dir + "\\" + num2.ToString("D" + maxDigits) + text;
                File.Move(text2, text3);
                num2--;
                if (num2 == 0)
                {
                    num3 = num4 - 1;
                    break;
                }
            }
            if (num3 != -1)
            {
                char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                for (int i = 0; i <= num3; i++)
                {
                    text2 = dir + "\\" + listBox1.Items[i].ToString();
                    text = new FileInfo(text2).Extension;
                    if (checkBox1.Checked && num3 < 26)
                    {
                        text3 = dir + "\\" + 0.ToString("D" + maxDigits) + letters[i % 26] + text;
                    }
                    else
                    {
                        text3 = dir + "\\" + 0.ToString("D" + maxDigits) + "-" + i.ToString("D" + maxDigits) + text;
                    }
                    File.Move(text2, text3);
                }
            }
            refreshList1(Directory.GetFiles(dir));
        }

        private void checkname()
        {
            string text = "";
            string text2 = "";
            string text3 = "";
            int maxDigits = Math.Max(3, (int)Math.Log10(listBox1.Items.Count) + 1);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                text2 = dir + "\\" + listBox1.Items[i].ToString();
                text = new FileInfo(text2).Extension;
                text3 = dir + "\\RenamerTmp" + DateTime.Now.ToString("yyyyMMddHHmmss");
                text3 = text3 + i.ToString("D" + maxDigits) + text;
                File.Move(text2, text3);
            }
            refreshList1(Directory.GetFiles(dir));
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
            if (array.Length == 1)
            {
                if (File.Exists(array[0]))
                {
                    array[0] = Path.GetDirectoryName(array[0]);
                }
                array = Directory.GetFiles(array[0]);
            }
            dir = new FileInfo(array[0]).DirectoryName;
            refreshList1(array);
        }

        private void refreshList1(string[] fz)
        {
            listBox1.Update();
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.SetSelected(listBox1.SelectedIndex, value: false);
            }
            listBox1.Items.Clear();
            foreach (string text in fz)
            {
                if ((text.IndexOf(".jp") >= 0) | (text.IndexOf(".bmp") >= 0) | (text.IndexOf(".gif") >= 0) |
                 (text.IndexOf(".png") >= 0) | (text.IndexOf(".tif") >= 0) | (text.IndexOf(".webp") >= 0) |
                 (text.IndexOf(".avif") >= 0))
                {
                    listBox1.Items.Add(new FileInfo(text).Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listBox1.Text.Equals(""))
            {
                myPainting();
            }
        }

        private void myPaintingClear()
        {
            Bitmap image = new Bitmap(10, 10);
            Bitmap image2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(image2);
            graphics.DrawImage(image, 0, 0);
            pictureBox1.Image = image2;
            pictureBox1.Invalidate();
            pictureBox1.Refresh();
        }

        private void myPainting()
        {
            try
            {
                Bitmap bitmap = new Bitmap(dir + "\\" + listBox1.Text);
                Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graphics = Graphics.FromImage(image);
                if (bitmap.Height > (int)pictureBox1.Height)
                {
                    Rectangle rect = new Rectangle(0, 0, bitmap.Width, pictureBox1.Height / 2);
                    Bitmap bitmap2 = bitmap.Clone(rect, bitmap.PixelFormat);
                    graphics.DrawImage(bitmap2, 0, 0, pictureBox1.Width, pictureBox1.Height / 2);
                    bitmap2.Dispose();
                    int num = bitmap.Height - pictureBox1.Height / 2;
                    rect = new Rectangle(0, num, bitmap.Width, pictureBox1.Height / 2);
                    bitmap2 = bitmap.Clone(rect, bitmap.PixelFormat);
                    graphics.DrawImage(bitmap2, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
                    bitmap2.Dispose();
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    bitmap.Dispose();
                }
                else
                {
                    Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                    Bitmap bitmap2 = bitmap.Clone(rect, bitmap.PixelFormat);
                    graphics.DrawImage(bitmap2, 0, 0, pictureBox1.Width, pictureBox1.Height);
                    bitmap2.Dispose();
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    bitmap.Dispose();
                }
            }
            catch (ArgumentException)
            {
                // Unsupported format
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dir))
                refreshList1(Directory.GetFiles(dir));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
