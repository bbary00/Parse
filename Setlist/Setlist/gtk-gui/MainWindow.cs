
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.ComboBox combobox1;

	private global::Gtk.ComboBox combobox3;

	private global::Gtk.ComboBox combobox2;

	private global::Gtk.Button button1;

	private global::Gtk.VBox vbox3;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label label1;

	private global::Gtk.ComboBox combobox6;

	private global::Gtk.ComboBox combobox7;

	private global::Gtk.ComboBox combobox8;

	private global::Gtk.VBox vbox2;

	private global::Gtk.ComboBox combobox5;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.combobox1 = global::Gtk.ComboBox.NewText();
		this.combobox1.Name = "combobox1";
		this.vbox1.Add(this.combobox1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.combobox1]));
		w1.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.combobox3 = global::Gtk.ComboBox.NewText();
		this.combobox3.Name = "combobox3";
		this.vbox1.Add(this.combobox3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.combobox3]));
		w2.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.combobox2 = global::Gtk.ComboBox.NewText();
		this.combobox2.Name = "combobox2";
		this.vbox1.Add(this.combobox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.combobox2]));
		w3.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("MainPage");
		this.vbox1.Add(this.button1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button1]));
		w4.Position = 3;
		w4.Fill = false;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w5.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Artist");
		this.vbox4.Add(this.label1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.combobox6 = global::Gtk.ComboBox.NewText();
		this.combobox6.Name = "combobox6";
		this.vbox4.Add(this.combobox6);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.combobox6]));
		w7.Position = 1;
		// Container child vbox4.Gtk.Box+BoxChild
		this.combobox7 = global::Gtk.ComboBox.NewText();
		this.combobox7.Name = "combobox7";
		this.vbox4.Add(this.combobox7);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.combobox7]));
		w8.Position = 2;
		// Container child vbox4.Gtk.Box+BoxChild
		this.combobox8 = global::Gtk.ComboBox.NewText();
		this.combobox8.Name = "combobox8";
		this.vbox4.Add(this.combobox8);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.combobox8]));
		w9.Position = 3;
		this.vbox3.Add(this.vbox4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox4]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		this.hbox1.Add(this.vbox3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.combobox5 = global::Gtk.ComboBox.NewText();
		this.combobox5.Name = "combobox5";
		this.vbox2.Add(this.combobox5);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.combobox5]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		this.hbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
		w13.Position = 2;
		w13.Fill = false;
		this.Add(this.hbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 794;
		this.DefaultHeight = 448;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.combobox1.Changed += new global::System.EventHandler(this.OnCombobox1Changed);
		this.combobox3.Changed += new global::System.EventHandler(this.OnCombobox3Changed);
		this.combobox2.Changed += new global::System.EventHandler(this.OnCombobox2Changed);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.combobox7.Changed += new global::System.EventHandler(this.OnCombobox7Changed);
	}
}