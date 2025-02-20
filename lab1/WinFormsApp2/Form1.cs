namespace WinFormsApp2
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            List<Transport> transportList = new List<Transport>
            {
                new Transport(),
                new Plane(),
                new Car(),
                new SportCar(),
                new CargoPlane(),
                new Truck(),
                new PassengerPlane()

            };

            for (int i = 0; i < transportList.Count; i++)
            {
                Label label = new Label();
                label.Size = new Size(200, 40);
                label.Location = new Point(i * 200 + 110, 100);
                label.Text = transportList[i].GetType().Name;
                this.Controls.Add(label);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 150); 
                pictureBox.Location = new Point(i * 200 + 80, 140); 
                pictureBox.BorderStyle = BorderStyle.FixedSingle; 
                pictureBox.Image = Image.FromFile(transportList[i].pictureURL); 
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 

                this.Controls.Add(pictureBox); 
            }

            InitializeComponent();
        }
    }

}
