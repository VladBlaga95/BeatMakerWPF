using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Speech.Recognition;
namespace BeatMakerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            InitButDyn();
            Engine.GenerateGradientBlue();
            Engine.GenerateGradientOrange();
            Engine.GenerateGradientGreen();
            Engine.GenerateGradientViolet();
            Engine.GenerateGradientRed();
            Choices commnads = new Choices();
            commnads.Add(Engine.x);
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commnads);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (e.Result.Text == Engine.but[i, j].Tag.ToString())
                        Engine.player[i, j].Play();
                }
            }
        }

        public void InitButDyn()
        {
            int cont = 1;
            StackPanel pn;
            Stream s;
            for (int i = 0; i <5; i++)
            {
     
                for (int j = 0; j < 5; j++)
                {
                    Engine.but[i, j] = new Button();
                    if (i==0)
                        Engine.but[i, j].Background = Engine.MyGradient;
                    else if(i==1)
                        Engine.but[i, j].Background = Engine.MyGradient2;
                    else if(i==2)
                        Engine.but[i, j].Background = Engine.MyGradient3;
                    else if (i == 3)
                        Engine.but[i, j].Background = Engine.MyGradient4;
                    else
                        Engine.but[i, j].Background = Engine.MyGradient5;
                    pn = new StackPanel();
                    s = Properties.Resources.ResourceManager.GetStream("_" + cont);
                    Engine.player[i, j] = new System.Media.SoundPlayer(s);
                    Engine.but[i, j].Name = "btn" + cont;
                    Engine.but[i, j].Content = pn;
                    Engine.but[i, j].Tag = cont;
                    Engine.but[i, j].HorizontalAlignment = HorizontalAlignment.Stretch;
                    Engine.but[i, j].VerticalAlignment = VerticalAlignment.Stretch;
                    Grid.SetColumn(Engine.but[i, j], j);
                    Grid.SetRow(Engine.but[i, j], i);
                    Engine.but[i, j].Click += But_Click;
                    Engine.but[i, j].MouseEnter += Effect_MouseEnter;
                    Engine.but[i, j].MouseLeave += Effect_MouseLeave;
                    Engine.but[i, j].MouseDoubleClick += Effect_MouseDoubleClick;
                    
                    MyGrid.Children.Add(Engine.but[i,j]);
                    cont++;
                }
            }
        }

        private void Effect_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Button btn = (sender as Button);
            //btn.Background = Engine.MyGradient2;
        }

        private void Effect_MouseLeave(object sender, MouseEventArgs e)
        {
         
        }

        private void Effect_MouseEnter(object sender, MouseEventArgs e)
        {
          
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            CheckVec(btn.Name);
           
        }

        public void CheckVec(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Engine.but[i, j].Name == s)
                    {
                        Engine.player[i, j].Play();
                       
                    }
                }
            }  
        }

        private void On_Click(object sender, RoutedEventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            Off.IsEnabled = true;
            On.IsEnabled = false;
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            Off.IsEnabled = false;
            On.IsEnabled = true;
        }
    }
}
