namespace mont
{
    public partial class Form1 : Form
    {
        int AnalyzeNumber = 1;
        int[] AnalyzeResult = { 0, 0, 0 };
        MontyHall montyprove = new MontyHall();

        public Form1()
        {
            InitializeComponent();
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            AnalyzeNumber = int.Parse(AnalyzeNumTextBox.Text);

            if (AnalyzeNumber != 0 && AnalyzeNumber > 0)
            {
                AnalyzeResult = montyprove.ProveMaontyHall(AnalyzeNumber);
            }
            else
            {
                ThrowException();
            }
                
            DisplayResult(AnalyzeResult);

        }

        private void DisplayResult(int[] Result)
        {
            WinByChange.Text = Result[0].ToString();
            TotalValue.Text = Result[1].ToString();
            LoseByChange.Text = Result[2].ToString();
            WinPercentage.Text = ($"{(float)Result[0] / Result[1]*100}%");
            LosePercentage.Text = ($"{(float)Result[2] / Result[1]*100}%");

        }

        private void ThrowException()
        {
            MessageBox.Show("°ª ¿À·ù");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoseByChange_Click(object sender, EventArgs e)
        {

        }

        private void WinByChange_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    internal class MontyHall
    {
        private int Win = 0;
        private int Lose = 0;
        private int[] Total = { 0, 0, 0 };

        private Random random = new Random();

        public int[] ProveMaontyHall(int AnalyzeNumber)
        {

            int[] Result = Analyze(AnalyzeNumber);

            Total[0] = Result[0];
            Total[1] = AnalyzeNumber;
            Total[2] = Result[1];

            return Total;
        }
        private int[] Analyze(int AnalyzeNumber)
        {
            int[] Result = {0, 0};

            byte SystemSelect = 0;
            byte HumanSelect = 0;

            for (int i = 0; i < AnalyzeNumber; i++)
            {
                SystemSelect = (byte)random.Next(1, 4);
                HumanSelect = (byte)random.Next(1, 4);

                if (SystemSelect == HumanSelect)
                {
                    Result[1]++;
                }
                else
                {
                    Result[0]++;
                }
            }

            return Result;
        }
        
    }
}
