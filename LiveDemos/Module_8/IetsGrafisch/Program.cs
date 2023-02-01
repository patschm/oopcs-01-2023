namespace IetsGrafisch;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hahahaha");
        Form f1 = new Form();
        f1.Text= "Hello";
        f1.BackColor = Color.Green; 
        f1.ForeColor = Color.Red;

        Button b1 = new Button();
        b1.BackColor = Color.Yellow;
        b1.Text = "Click me!!";
        b1.Location = new Point(70, 70);
        b1.Click += Klikkerdeklik;
        b1.Click += IetsAnders;

        f1.Controls.Add(b1);

        f1.ShowDialog();
        Console.ReadLine();
    }

    static void Klikkerdeklik(object? sender, EventArgs e)
    {
        Button? b1 = sender as Button;
        b1.Text = "Ouch!!!";
        b1.Parent.BackColor = Color.Blue;

        TextBox t1 = new TextBox();
        t1.Location = new Point(10, 20);
        b1.Parent.Controls.Add(t1);
    }
    static void IetsAnders(object? sender, EventArgs e)
    {
        MessageBox.Show("Haha!!!", "Mooi", MessageBoxButtons.OKCancel);
    }
}