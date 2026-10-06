namespace TV_Formaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* =======Analyse Stap 1======
1. Welke functies heb je nodig? Noteer voor elke functie een naam. Zorg ervoor dat de naam onmiddellijke duidelijk is voor wat deze functie moet doen.
        BerekenHoogte
        BerekenBreedte
        HoogteInchToCm
        BreedteInchToCm
        DiagonaalInchToCm

=======Analyse Stap 2======
BerekenHoogte
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        DiagonaleLengteInch - double
        AspectRatioBreedte - int
        AspectRatiohoogte - int

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        verhouding = diagonale lengte / (Math.Sqrt(Math.Pow(Breedte, 2) + Math.Pow(Hoogte, 2)))
        hoogteInInch = verhouding * aspectRatioHoogte

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        31,9 inch - double

BerekenBreedte
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        DiagonaleLengteInch - double
        AspectRatioBreedte - int
        AspectRatioHoogte - int

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        verhouding = diagonale lengte / (Math.Sqrt(Math.Pow(Breedte, 2) + Math.Pow(Hoogte, 2)))
        breedteInInch = verhouding * aspectRatioBreedte

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        56,7 inch - double

HoogteInchToCm
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        HoogteInch - double

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        cm = inch * 2.54

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        HoogteInch = 31,9 -> 80,9

BreedteInchToCm
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        BreedteInch - double

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        cm = inch * 2.54

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        BreedteInch = 56,7 -> 143,9

DiagonaalInchToCm
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        DiagonaleLengteInch - double

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        cm = inch * 2.54

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        DiagonaleLengteInch = 65 -> 165,1

==========Testdata=========

4. Testdata: Verzin en noteer testgegevens, en bereken met je rekenmachine de juiste oplossing. Zo weet je of je oefening klopt.
        diagonaal = 65 inch 
        aspect ratio breedte = 16
        aspect ratio hoogte = 9
        naar
        diagonaal = 165,1 cm
        breedte inch = 56,7
        breedte centimeters = 143,9 cm
        hoogte inch = 31,9
        hoogte centimeters = 80,9 cm

=========================== */
        private void button1_Click(object sender, EventArgs e)
        {
            double DiagonaleLengteInch = Convert.ToDouble(DiagonaalTextBox.Text);
            int AspectRatioBreedte = Convert.ToInt32(BreedteTextBox.Text);
            int AspectRatioHoogte = Convert.ToInt32(HoogteTextBox.Text);
            double HoogteInch = BerekenHoogte(DiagonaleLengteInch, AspectRatioBreedte, AspectRatioHoogte);
            double BreedteInch = BerekenBreedte(DiagonaleLengteInch, AspectRatioBreedte, AspectRatioHoogte);
            double HoogteCm = HoogteInchToCm(HoogteInch);
            double BreedteCm = BreedteInchToCm(BreedteInch);
            double diagonaleLengteCm = DiagonaalInchToCm(DiagonaleLengteInch);
            DiagonaalCmLabel.Text = Convert.ToString(Math.Round(diagonaleLengteCm, 1) + " cm");
            HoogteInchLabel.Text = Convert.ToString(Math.Round(HoogteInch, 1) + " inch");
            HoogteCmLabel.Text = Convert.ToString(Math.Round(HoogteCm, 1) + " cm");
            BreedteInchLabel.Text = Convert.ToString(Math.Round(BreedteInch, 1) + " inch");
            BreedteCmLabel.Text = Convert.ToString(Math.Round(BreedteCm, 1) + " cm");

        }


        private double BerekenHoogte(double DiagonaleLengteInch, int AspectRatioBreedte, int AspectRatioHoogte)
        {
            double verhouding = DiagonaleLengteInch / (Math.Sqrt(Math.Pow(AspectRatioBreedte, 2) + Math.Pow(AspectRatioHoogte, 2)));
            return verhouding * AspectRatioHoogte;
        }


        private double BerekenBreedte(double DiagonaleLengteInch, int AspectRatioBreedte, int AspectRatioHoogte)
        {
            double verhouding = DiagonaleLengteInch / (Math.Sqrt(Math.Pow(AspectRatioBreedte, 2) + Math.Pow(AspectRatioHoogte, 2)));
            return verhouding * AspectRatioBreedte;
        }


        private double DiagonaalInchToCm(double DiagonaleLengteInch)
        {
            return DiagonaleLengteInch * 2.54;
        }

        private double HoogteInchToCm(double HoogteInch)
        {
            return HoogteInch * 2.54;
        }


        private double BreedteInchToCm(double BreedteInch)
        {
            return BreedteInch * 2.54;
        }
    }
}
