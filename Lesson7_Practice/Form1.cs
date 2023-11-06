namespace Lesson7_Practice
{

    //—оздать меню на 5 пунктов, 2 из которых сделать дочерними.
    //    —оздание и добавление меню, реализовать через код формы.
    //    ƒобавить обработчики по нажатию на пункты меню, при нажати€
    //    выводить сообщение о том, какой пункт был выбран.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ("File");
            ToolStripMenuItem editMenu = new ("Edit");
            ToolStripMenuItem viewMenu = new ("View");
            ToolStripMenuItem optionsMenu = new ("Options");
            ToolStripMenuItem helpMenu = new ("Help");
            ToolStripMenuItem pasteMenuItem = new ("Paste");
            ToolStripMenuItem copyMenuItem = new ("Copy");

            editMenu.DropDownItems.Add(pasteMenuItem);
            editMenu.DropDownItems.Add(copyMenuItem);


            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);
            menuStrip.Items.Add(viewMenu);
            menuStrip.Items.Add(optionsMenu);
            menuStrip.Items.Add(helpMenu);

            this.MainMenuStrip = menuStrip;

            pasteMenuItem.Click += (sender, e) => MessageBox.Show("Paste");
            copyMenuItem.Click += (sender, e) => MessageBox.Show("Copy");

            this.Controls.Add(menuStrip);
        }
    }
}