using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projekt3_Zalewski_51343
{


    public partial class Form1 : Form
    {

        Graphics pzRysownica;
        const int pzMargines = 50;
        const int pzMaxGrubośćLinii = 10;
        const float pzKątProsty = 90.0F;
        public static Form1 pzUchwytFormularza;
        static bool pzKierunekObrotu;
        List<pzBryłaAbstrakcyjna> pzLBG = new List<pzBryłaAbstrakcyjna>();


        public Form1()

        {
            InitializeComponent();
            pzpbPowierzchniaGraficzna.Image = new Bitmap(pzpbPowierzchniaGraficzna.Width, pzpbPowierzchniaGraficzna.Height);
            pzRysownica = Graphics.FromImage(pzpbPowierzchniaGraficzna.Image);
            pztimerObrotów.Enabled = true;
        }


        DashStyle pzWybórStylu(int pzN)
        {
            switch (pzN)
            {
                case 1:
                    return DashStyle.Dash;

                case 2:
                    return DashStyle.DashDot;

                case 3:
                    return DashStyle.DashDotDot;

                case 4:
                    return DashStyle.Dot;

                case 5:
                    return DashStyle.Solid;

                default:
                    return DashStyle.Solid;

            }
        }


        abstract class pzBryłaAbstrakcyjna
        {

            public enum pzTypBryły
            {
                Walec, Stożek, Kula, Ostrosłup, Graniastosłup, Sześcian
            }
            protected int pzXsS, pzYsS;
            protected int pzXsP, pzYsP;
            public int pzWysokośćBryły;
            protected float pzKątPochylenia;
            protected int pzGrubośćLinii;
            protected Color pzKolorLinii;
            protected DashStyle pzStylLinii;
            public pzTypBryły pzRodzajBryły;
            public float pzPowierzchniaBryły;
            public float pzObjętośćBryły;


            public pzBryłaAbstrakcyjna(Color pzKolorLinii1, DashStyle pzStylLinii1, int pzGrubośćLinii1)
            {
                this.pzKolorLinii = pzKolorLinii1;
                this.pzStylLinii = pzStylLinii1;
                this.pzGrubośćLinii = pzGrubośćLinii1;
                this.pzKątPochylenia = 90.0F;
            }

            public abstract void pzWykreśl(Graphics pzPowierzchniaGraficzna);

            public abstract void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna);

            public abstract void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu);

            public abstract void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY);

            public void pzUstalAtrybutyGraficzne(Color pzKolorLinii1, DashStyle pzStylLinii1, int pzGrubośćLinii1)
            {
                this.pzKolorLinii = pzKolorLinii1;
                this.pzStylLinii = pzStylLinii1;
                this.pzGrubośćLinii = pzGrubośćLinii1;
            }
        }

        class pzBryłyObrotowe : pzBryłaAbstrakcyjna
        {
            protected int pzPromieńBryły
                ;
            public pzBryłyObrotowe(int pzR, Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                this.pzPromieńBryły = pzR;
            }
            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                //
            }
            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                //
            }
            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                //
            }
            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                //
            }
        }

        class pzWielościany : pzBryłaAbstrakcyjna
        {
            protected int pzStopieńWielokątaPodstawy;
            protected int pzPromieńBryły;

            public pzWielościany(int pzR, int pzStopieńWielokątaPodstawy, Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                pzPromieńBryły = pzR;
                this.pzStopieńWielokątaPodstawy = pzStopieńWielokątaPodstawy;
            }
            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                //
            }
            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                //
            }
            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                //
            }
            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                //
            }
        }

        class pzStożek : pzBryłyObrotowe
        {
            int pzStopieńWielokątaPodstawy;
            float pzOśDuża, pzOśMała;
            float pzKątMiędzyWierzchołkami;
            float pzKątPołożenia;
            Point[] pzWielokątPodłogi;
            int pzWektorPrzesunięciaWierzchołkaStożka;

            public pzStożek(int pzR, int pzWysokośćStożka, int pzStopieńWielokątaPodstawyStożka, int pzXsP, int pzYsP, float pzKątPochyleniaStożka, 
                Color pzKolorLinii, DashStyle pzStyliLinii, int pzGrubośćLinii) : base(pzR, pzKolorLinii, pzStyliLinii, pzGrubośćLinii)
            {
                this.pzRodzajBryły = pzTypBryły.Stożek;
                this.pzWysokośćBryły = pzWysokośćStożka;
                this.pzKątPochylenia = pzKątPochyleniaStożka;
                this.pzStopieńWielokątaPodstawy = pzStopieńWielokątaPodstawyStożka;
                this.pzOśDuża = this.pzPromieńBryły * 2;
                this.pzOśMała = this.pzPromieńBryły / 2;
                if (pzKątPochyleniaStożka < pzKątProsty)
                {
                    float pzKątBeta = pzKątProsty - pzKątPochyleniaStożka;
                    pzWektorPrzesunięciaWierzchołkaStożka = (int)(pzWysokośćStożka * (float)(Math.Tan(pzKątBeta * (Math.PI / 180F))));
                    pzXsS = pzXsP + pzWektorPrzesunięciaWierzchołkaStożka;
                }

                else if (pzKątPochyleniaStożka > pzKątProsty)
                {
                    float pzKątBeta = pzKątPochyleniaStożka - pzKątProsty;
                    pzWektorPrzesunięciaWierzchołkaStożka = (int)(pzWysokośćStożka * (float)(Math.Tan(pzKątBeta * Math.PI / 180F)));
                    pzXsS = pzXsP - pzWektorPrzesunięciaWierzchołkaStożka;
                }

                else
                    pzXsS = pzXsP;
                this.pzYsS = pzYsP - pzWysokośćStożka;
                this.pzXsP = pzXsP;
                this.pzYsP = pzYsP;
                this.pzKątMiędzyWierzchołkami = 360 / pzStopieńWielokątaPodstawy;
                this.pzKątPołożenia = 0F;
                this.pzWielokątPodłogi = new Point[pzStopieńWielokątaPodstawy + 1];

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(this.pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                    pzWielokątPodłogi[i].Y = (int)(this.pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                }
                this.pzObjętośćBryły = (float)(Math.PI * Math.Pow(this.pzPromieńBryły, 2) * this.pzWysokośćBryły) / 3;
                this.pzPowierzchniaBryły = (float)(Math.PI * this.pzPromieńBryły * (this.pzPromieńBryły + Math.Sqrt(this.pzWysokośćBryły * this.pzWysokośćBryły + this.pzPromieńBryły * this.pzPromieńBryły)));
            }

            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(this.pzKolorLinii, this.pzGrubośćLinii);
                pzPióro.DashStyle = this.pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, this.pzXsP - this.pzOśDuża / 2, this.pzYsP - this.pzOśMała / 2, this.pzOśDuża, this.pzOśMała);
                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], new Point(this.pzXsS, this.pzYsS));
                pzPióro.Dispose();
            }

            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(pzKontrolka.BackColor, this.pzGrubośćLinii);
                pzPióro.DashStyle = this.pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, this.pzXsP - this.pzOśDuża / 2, this.pzYsP - this.pzOśMała / 2, this.pzOśDuża, this.pzOśMała);
                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], new Point(this.pzXsS, this.pzYsS));
                pzPióro.Dispose();
            }

            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                if (!pzKierunekObrotu)
                    this.pzKątPołożenia += pzKątObrotu;
                else
                    this.pzKątPołożenia -= pzKątObrotu;
                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(this.pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                    pzWielokątPodłogi[i].Y = (int)(this.pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                }
                pzWykreśl(pzPowierzchniaGraficzna);
            }

            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                int pzdX = pzXsP < pzX ? pzdX = pzX - pzXsP : pzdX = -(pzXsP - pzX);
                int pzdY = pzYsP < pzY ? pzdY = pzY - pzYsP : pzdY = -(pzYsP - pzY);
                this.pzXsP = pzXsP + pzdX;
                this.pzYsP = pzYsP + pzdY;
                this.pzXsS = pzXsS + pzdX;
                this.pzYsS = pzYsS + pzdY;
                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(this.pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                    pzWielokątPodłogi[i].Y = (int)(this.pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożenia + i * pzKątMiędzyWierzchołkami) / 180F));
                }
                pzWykreśl(pzPowierzchniaGraficzna);
            }
        }

        class pzWalec : pzBryłyObrotowe
        {
            Point[] pzWielokątPodłogi;
            Point[] pzWielokątSufitu;
            int pzStopieńWielokątaPodstawy;
            int pzWektorPrzesunięciaWierzchołka;
            float pzOśDuża, pzOśMała;
            float pzKątMiędzyWierzchołkami;
            float pzKątPołożeniaPierwszegoWierzchołka;

            public pzWalec(int pzR, int pzWysokość, int pzStopieńWielokątaPodstawy, int pzXsP, int pzYsP, float pzKątPochyleniaBryły, 
                Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzR, pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                this.pzRodzajBryły = pzTypBryły.Walec;
                this.pzWysokośćBryły = pzWysokość;
                this.pzStopieńWielokątaPodstawy = pzStopieńWielokątaPodstawy;
                this.pzXsP = pzXsP;
                this.pzYsP = pzYsP;
                this.pzKątPochylenia = pzKątPochyleniaBryły;
                pzOśDuża = pzR * 2;
                pzOśMała = pzR / 2;
                pzYsS = pzYsP - pzWysokość;

                if (pzKątPochyleniaBryły < 90)
                {
                    float pzKątBeta = 90 - pzKątPochyleniaBryły;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokość * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP + pzWektorPrzesunięciaWierzchołka;
                }

                else if (pzKątPochyleniaBryły > 90)
                {
                    float pzKątBeta = pzKątPochyleniaBryły - 90;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokośćBryły * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP - pzWektorPrzesunięciaWierzchołka;
                }

                else
                {
                    pzXsS = pzXsP;
                }

                this.pzYsS = pzYsP - pzWysokośćBryły;
                this.pzKątMiędzyWierzchołkami = 360 / pzStopieńWielokątaPodstawy;
                pzKątPołożeniaPierwszegoWierzchołka = 0;
                this.pzWielokątPodłogi = new Point[pzStopieńWielokątaPodstawy + 1];
                this.pzWielokątSufitu = new Point[pzStopieńWielokątaPodstawy + 1];

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i] = new Point();
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                this.pzObjętośćBryły = (float)(Math.PI * Math.Pow(this.pzPromieńBryły, 2) * this.pzWysokośćBryły) / 3;
                this.pzPowierzchniaBryły = (float)(Math.PI * this.pzPromieńBryły * (this.pzPromieńBryły + Math.Sqrt(this.pzWysokośćBryły * this.pzWysokośćBryły + this.pzPromieńBryły * this.pzPromieńBryły)));
            }

            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(this.pzKolorLinii, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsP - pzOśDuża / 2, pzYsP - pzOśMała / 2, pzOśDuża, pzOśMała);
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsS - pzOśDuża / 2, pzYsS - pzOśMała / 2, pzOśDuża, pzOśMała);
                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);
                pzPióro.Dispose();
            }

            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(pzKontrolka.BackColor, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsP - pzOśDuża / 2, pzYsP - pzOśMała / 2, pzOśDuża, pzOśMała);
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsS - pzOśDuża / 2, pzYsS - pzOśMała / 2, pzOśDuża, pzOśMała);
                pzPowierzchniaGraficzna.DrawLine(pzPióro, pzXsP - pzOśDuża / 2, pzYsP, pzXsS - pzOśDuża / 2, pzYsS);
                pzPowierzchniaGraficzna.DrawLine(pzPióro, pzXsP + pzOśDuża / 2, pzYsP, pzXsS + pzOśDuża / 2, pzYsS);

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);
                pzPióro.Dispose();
            }

            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);

                if (!pzKierunekObrotu)
                    pzKątPołożeniaPierwszegoWierzchołka += pzKątObrotu;

                else
                    pzKątPołożeniaPierwszegoWierzchołka -= pzKątObrotu;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                pzWykreśl(pzPowierzchniaGraficzna);
            }

            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                int pzdX = pzXsP < pzX ? pzdX = pzX - pzXsP : pzdX = -(pzXsP - pzX);
                int pzdY = pzYsP < pzY ? pzdY = pzY - pzYsP : pzdY = -(pzYsP - pzY);
                pzXsP = pzXsP + pzdX;
                pzYsP = pzYsP + pzdY;
                pzXsS = pzXsS + pzdX;
                pzYsS = pzYsS + pzdY;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                pzWykreśl(pzPowierzchniaGraficzna);
            }
        }

        class pzKula : pzBryłyObrotowe
        {
            Point pzWielokątPodłogi;
            Point pzWielokątSufitu;
            float pzOśDuża, pzOśMała;
            float pzKątMiędzyWierzchołkami;
            float pzKątPołożeniaPierwszegoWierzchołka;

            public pzKula(int pzR, int pzXsP, int pzYsP, Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzR, pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                this.pzRodzajBryły = pzTypBryły.Kula;
                this.pzXsP = pzXsP;
                this.pzYsP = pzYsP;
                pzOśDuża = pzR * 2;
                pzOśMała = pzR / 2;
                this.pzYsS = pzYsP - pzWysokośćBryły;
                this.pzKątMiędzyWierzchołkami = 360;
                pzKątPołożeniaPierwszegoWierzchołka = 0;
                this.pzWielokątPodłogi = new Point();
                this.pzWielokątSufitu = new Point();
                pzWielokątPodłogi = new Point();
                pzWielokątPodłogi.X = (int)(pzXsP);
                pzWielokątPodłogi.Y = (int)(pzYsP);
                pzWielokątSufitu = new Point();
                pzWielokątSufitu.X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));
                pzWielokątSufitu.Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));
                this.pzObjętośćBryły = (float)(Math.PI * Math.Pow(this.pzPromieńBryły, 2) * this.pzWysokośćBryły) / 3;
                this.pzPowierzchniaBryły = (float)(Math.PI * this.pzPromieńBryły * (this.pzPromieńBryły + Math.Sqrt(this.pzWysokośćBryły * this.pzWysokośćBryły + this.pzPromieńBryły * this.pzPromieńBryły)));
            }

            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(this.pzKolorLinii, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsP - pzOśDuża / 2, pzYsP - pzOśMała / 2, pzOśDuża, pzOśMała);
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsP - pzOśDuża / 2, pzYsP - pzOśDuża / 2, pzOśDuża, pzOśDuża);
                pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi, pzWielokątSufitu);

                pzPióro.Dispose();
            }

            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(pzKontrolka.BackColor, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawEllipse(pzPióro, pzXsP - pzOśDuża / 2, pzYsP - pzOśMała / 2, pzOśDuża, pzOśMała);
                pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi, pzWielokątSufitu);

                pzPióro.Dispose();
            }

            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                if (!pzKierunekObrotu)
                    pzKątPołożeniaPierwszegoWierzchołka += pzKątObrotu;
                else
                    pzKątPołożeniaPierwszegoWierzchołka -= pzKątObrotu;
                pzWielokątSufitu.X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));
                pzWielokątSufitu.Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));

                pzWykreśl(pzPowierzchniaGraficzna);
            }

            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                int pzdX = pzXsP < pzX ? pzdX = pzX - pzXsP : pzdX = -(pzXsP - pzX);
                int pzdY = pzYsP < pzY ? pzdY = pzY - pzYsP : pzdY = -(pzYsP - pzY);
                pzXsP = pzXsP + pzdX;
                pzYsP = pzYsP + pzdY;
                pzWielokątPodłogi = new Point();
                pzWielokątPodłogi.X = (int)(pzXsP);
                pzWielokątPodłogi.Y = (int)(pzYsP);
                pzWielokątSufitu.X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));
                pzWielokątSufitu.Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + 0 * pzKątMiędzyWierzchołkami) / 180));

                pzWykreśl(pzPowierzchniaGraficzna);
            }
        }

        class pzOstrosłup : pzWielościany
        {
            Point[] pzWielokątPodłogi;
            Point[] pzWielokątSufitu;
            int pzWektorPrzesunięciaWierzchołka;
            float pzOśDuża, pzOśMała;
            float pzKątMiędzyWierzchołkami;
            float pzKątPołożeniaPierwszegoWierzchołka;

            public pzOstrosłup(int pzR, int pzWysokość, int pzStopieńWielokątaPodstawy, int pzXsP, int pzYsP, float pzKątPochyleniaBryły, 
                Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzR, pzStopieńWielokątaPodstawy, pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                this.pzRodzajBryły = pzTypBryły.Walec;
                this.pzWysokośćBryły = pzWysokość;
                this.pzStopieńWielokątaPodstawy = pzStopieńWielokątaPodstawy;
                this.pzXsP = pzXsP;
                this.pzYsP = pzYsP;
                this.pzKątPochylenia = pzKątPochyleniaBryły;
                pzOśDuża = pzR * 2;
                pzOśMała = pzR / 2;
                pzYsS = pzYsP - pzWysokość;

                if (pzKątPochyleniaBryły < 90)
                {
                    float pzKątBeta = 90 - pzKątPochyleniaBryły;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokość * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP + pzWektorPrzesunięciaWierzchołka;
                }

                else if (pzKątPochyleniaBryły > 90)
                {
                    float pzKątBeta = pzKątPochyleniaBryły - 90;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokośćBryły * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP - pzWektorPrzesunięciaWierzchołka;
                }

                else
                {
                    pzXsS = pzXsP;
                }
                this.pzYsS = pzYsP - pzWysokośćBryły;
                this.pzKątMiędzyWierzchołkami = 360 / pzStopieńWielokątaPodstawy;
                pzKątPołożeniaPierwszegoWierzchołka = 0;
                this.pzWielokątPodłogi = new Point[pzStopieńWielokątaPodstawy + 1];
                this.pzWielokątSufitu = new Point[pzStopieńWielokątaPodstawy + 1];

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i] = new Point();
                    pzWielokątSufitu[i].X = (int)(pzXsS);
                    pzWielokątSufitu[i].Y = (int)(pzYsS);
                }

                this.pzObjętośćBryły = (float)(Math.PI * Math.Pow(this.pzPromieńBryły, 2) * this.pzWysokośćBryły) / 3;
                this.pzPowierzchniaBryły = (float)(Math.PI * this.pzPromieńBryły * (this.pzPromieńBryły + Math.Sqrt(this.pzWysokośćBryły * this.pzWysokośćBryły + this.pzPromieńBryły * this.pzPromieńBryły)));
            }

            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(this.pzKolorLinii, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątPodłogi);

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);

                pzPióro.Dispose();
            }

            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(pzKontrolka.BackColor, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątPodłogi);

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);

                pzPióro.Dispose();
            }

            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);

                if (!pzKierunekObrotu)
                    pzKątPołożeniaPierwszegoWierzchołka += pzKątObrotu;

                else
                    pzKątPołożeniaPierwszegoWierzchołka -= pzKątObrotu;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i] = new Point();
                    pzWielokątSufitu[i].X = (int)(pzXsS);
                    pzWielokątSufitu[i].Y = (int)(pzYsS);
                }
                pzWykreśl(pzPowierzchniaGraficzna);
            }

            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                int pzdX = pzXsP < pzX ? pzdX = pzX - pzXsP : pzdX = -(pzXsP - pzX);
                int pzdY = pzYsP < pzY ? pzdY = pzY - pzYsP : pzdY = -(pzYsP - pzY);
                pzXsP = pzXsP + pzdX;
                pzYsP = pzYsP + pzdY;
                pzXsS = pzXsS + pzdX;
                pzYsS = pzYsS + pzdY;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i].X = (int)(pzXsS);
                    pzWielokątSufitu[i].Y = (int)(pzYsS);
                }
                pzWykreśl(pzPowierzchniaGraficzna);
            }
        }


        class pzGraniastosłup : pzWielościany
        {
            Point[] pzWielokątPodłogi;
            Point[] pzWielokątSufitu;
            int pzWektorPrzesunięciaWierzchołka;
            float pzOśDuża, pzOśMała;
            float pzKątMiędzyWierzchołkami;
            float pzKątPołożeniaPierwszegoWierzchołka;

            public pzGraniastosłup(int pzR, int pzWysokość, int pzStopieńWielokątaPodstawy, int pzXsP, int pzYsP, float pzKątPochyleniaBryły,
                Color pzKolorLinii, DashStyle pzStylLinii, int pzGrubośćLinii) : base(pzR, pzStopieńWielokątaPodstawy, pzKolorLinii, pzStylLinii, pzGrubośćLinii)
            {
                this.pzRodzajBryły = pzTypBryły.Walec;
                this.pzWysokośćBryły = pzWysokość;
                this.pzStopieńWielokątaPodstawy = pzStopieńWielokątaPodstawy;
                this.pzXsP = pzXsP;
                this.pzYsP = pzYsP;
                this.pzKątPochylenia = pzKątPochyleniaBryły;
                pzOśDuża = pzR * 2;
                pzOśMała = pzR / 2;
                pzYsS = pzYsP - pzWysokość;

                if (pzKątPochyleniaBryły < 90)
                {
                    float pzKątBeta = 90 - pzKątPochyleniaBryły;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokość * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP + pzWektorPrzesunięciaWierzchołka;
                }

                else if (pzKątPochyleniaBryły > 90)
                {
                    float pzKątBeta = pzKątPochyleniaBryły - 90;
                    pzWektorPrzesunięciaWierzchołka = (int)(pzWysokośćBryły * (float)(Math.Tan(pzKątBeta * (Math.PI / 180))));
                    pzXsS = pzXsP - pzWektorPrzesunięciaWierzchołka;
                }

                else
                {
                    pzXsS = pzXsP;
                }

                this.pzYsS = pzYsP - pzWysokośćBryły;
                this.pzKątMiędzyWierzchołkami = 360 / pzStopieńWielokątaPodstawy;
                pzKątPołożeniaPierwszegoWierzchołka = 0;
                this.pzWielokątPodłogi = new Point[pzStopieńWielokątaPodstawy + 1];
                this.pzWielokątSufitu = new Point[pzStopieńWielokątaPodstawy + 1];

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i] = new Point();
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }
                this.pzObjętośćBryły = (float)(Math.PI * Math.Pow(this.pzPromieńBryły, 2) * this.pzWysokośćBryły) / 3;
                this.pzPowierzchniaBryły = (float)(Math.PI * this.pzPromieńBryły * (this.pzPromieńBryły + Math.Sqrt(this.pzWysokośćBryły * this.pzWysokośćBryły + this.pzPromieńBryły * this.pzPromieńBryły)));
            }

            public override void pzWykreśl(Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(this.pzKolorLinii, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątPodłogi);
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątSufitu);

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);
                pzPióro.Dispose();
            }

            public override void pzWymaż(Control pzKontrolka, Graphics pzPowierzchniaGraficzna)
            {
                Pen pzPióro = new Pen(pzKontrolka.BackColor, pzGrubośćLinii);
                pzPióro.DashStyle = pzStylLinii;
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątPodłogi);
                pzPowierzchniaGraficzna.DrawPolygon(pzPióro, pzWielokątSufitu);

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                    pzPowierzchniaGraficzna.DrawLine(pzPióro, pzWielokątPodłogi[i], pzWielokątSufitu[i]);
                pzPióro.Dispose();
            }

            public override void pzObróćIWykreśl(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, float pzKątObrotu)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);

                if (!pzKierunekObrotu)
                    pzKątPołożeniaPierwszegoWierzchołka += pzKątObrotu;

                else
                    pzKątPołożeniaPierwszegoWierzchołka -= pzKątObrotu;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i] = new Point();
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i] = new Point();
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                pzWykreśl(pzPowierzchniaGraficzna);
            }

            public override void pzPrzesuńDoNowegoXY(Control pzKontrolka, Graphics pzPowierzchniaGraficzna, int pzX, int pzY)
            {
                pzWymaż(pzKontrolka, pzPowierzchniaGraficzna);
                int pzdX = pzXsP < pzX ? pzdX = pzX - pzXsP : pzdX = -(pzXsP - pzX);
                int pzdY = pzYsP < pzY ? pzdY = pzY - pzYsP : pzdY = -(pzYsP - pzY);
                pzXsP = pzXsP + pzdX;
                pzYsP = pzYsP + pzdY;
                pzXsS = pzXsS + pzdX;
                pzYsS = pzYsS + pzdY;

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątPodłogi[i].X = (int)(pzXsP + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątPodłogi[i].Y = (int)(pzYsP + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                for (int i = 0; i <= pzStopieńWielokątaPodstawy; i++)
                {
                    pzWielokątSufitu[i].X = (int)(pzXsS + pzOśDuża / 2 * Math.Cos(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                    pzWielokątSufitu[i].Y = (int)(pzYsS + pzOśMała / 2 * Math.Sin(Math.PI * (pzKątPołożeniaPierwszegoWierzchołka + i * pzKątMiędzyWierzchołkami) / 180));
                }

                pzWykreśl(pzPowierzchniaGraficzna);
            }
        }

        private void pztimerObrotów_Tick(object sender, EventArgs e)
        {
            if (pzcmbListaBrył.SelectedIndex == 5)
            {
                pztbKątNachyleniaBryły.Visible = false;
                pzlabel4.Visible = false;
                pznumStopieńWielokąta.Visible = false;
                pzlabel3.Visible = false;
                kmmlblKątPochylenia.Visible = false;
            }

            else if (pzcmbListaBrył.SelectedIndex == 2)
            {
                pztbKątNachyleniaBryły.Visible = false;
                pzlabel4.Visible = false;
                pznumStopieńWielokąta.Visible = false;
                pzlabel3.Visible = false;
                pztbWysokośćBryły.Visible = false;
                pzlabel2.Visible = false;
            }

            else
            {
                pztbKątNachyleniaBryły.Visible = true;
                pzlabel4.Visible = true;
                pznumStopieńWielokąta.Visible = true;
                pzlabel3.Visible = true;
                pztbWysokośćBryły.Visible = true;
                pzlabel2.Visible = true;
            }

            for (int i = 0; i < pzLBG.Count; i++)
                pzLBG[i].pzObróćIWykreśl(pzpbPowierzchniaGraficzna, pzRysownica, 5F);
            pzpbPowierzchniaGraficzna.Refresh();
        }

        private void pzbtnDodajNowąBryłe_Click(object sender, EventArgs e)
        {
            string pzRodzajBryły;
            int pzPromieńBryły;
            int pzWysokośćBryły;
            int pzStopieńWielokątaBryły;
            float pzKątPochyleniaBryły;
            int pzXmax, pzYmax;
            int pzWspółrzędnaXPodłogiBryły;
            int pzWspółrzędnaYPodłogiBryły;
            Color pzKolorLinii;
            DashStyle pzStylLinii;
            int pzGrubośćLinii;

            if (pzcmbListaBrył.SelectedIndex < 0)
            {
                errorProvider1.SetError(pzcmbListaBrył, "Musisz wybrać figurę geometryczną");
                return;
            }

            else
                errorProvider1.Dispose();
            pzXmax = pzpbPowierzchniaGraficzna.Width;
            pzYmax = pzpbPowierzchniaGraficzna.Height;
            Random pzGenerujLiczbęLosową = new Random();
            pzKolorLinii = Color.FromArgb(pzGenerujLiczbęLosową.Next(0, 255), pzGenerujLiczbęLosową.Next(0, 255), pzGenerujLiczbęLosową.Next(0, 255));
            pzStylLinii = pzWybórStylu(pzGenerujLiczbęLosową.Next(4));
            pzGrubośćLinii = pzGenerujLiczbęLosową.Next(1, 6);
            pzRodzajBryły = pzcmbListaBrył.Text;
            pzPromieńBryły = pztbPromieńBryły.Value;
            pzWysokośćBryły = pztbWysokośćBryły.Value;
            pzStopieńWielokątaBryły = (int)pznumStopieńWielokąta.Value;
            pzKątPochyleniaBryły = (float)pztbKątNachyleniaBryły.Value;
            pzWspółrzędnaXPodłogiBryły = pzGenerujLiczbęLosową.Next(pzPromieńBryły, pzXmax);
            pzWspółrzędnaYPodłogiBryły = pzGenerujLiczbęLosową.Next(pzWysokośćBryły, pzYmax);
            switch (pzRodzajBryły)
            {
                case "Walec":
                    pzWalec pzWalec = new pzWalec(pzPromieńBryły, pzWysokośćBryły, pzStopieńWielokątaBryły, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły, pzKątPochyleniaBryły, pzKolorLinii, pzStylLinii, pzGrubośćLinii);
                    pzLBG.Add(pzWalec);
                    break;
                case "Kula":
                    pzKula pzKula = new pzKula(pzPromieńBryły, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły, pzKolorLinii, pzStylLinii, pzGrubośćLinii);
                    pzLBG.Add(pzKula);
                    break;
                case "Stożek":
                    pzStożek pzStożek = new pzStożek(pzPromieńBryły, pzWysokośćBryły, pzStopieńWielokątaBryły, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły, pzKątPochyleniaBryły, pzKolorLinii, pzStylLinii, pzGrubośćLinii);
                    pzLBG.Add(pzStożek);
                    break;
                case "Ostrosłup":
                    pzOstrosłup pzOstrosłup = new pzOstrosłup(pzPromieńBryły, pzWysokośćBryły, pzStopieńWielokątaBryły, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły, pzKątPochyleniaBryły, pzKolorLinii, pzStylLinii, pzGrubośćLinii);
                    pzLBG.Add(pzOstrosłup);
                    break;
                case "Graniastosłup":
                    pzGraniastosłup pzGraniastosłup = new pzGraniastosłup(pzPromieńBryły, pzWysokośćBryły, pzStopieńWielokątaBryły, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły, pzKątPochyleniaBryły, pzKolorLinii, pzStylLinii, pzGrubośćLinii);
                    pzLBG.Add(pzGraniastosłup);
                    break;
                default:
                    MessageBox.Show("Nie rozpoznano figury geometrycznej");
                    break;
            }
            pzpbPowierzchniaGraficzna.Refresh();
            pzbtnKierunekObrotuLewo.Enabled = true;
            pzbtnKierunekObrotuPrawo.Enabled = true;
            pzbtnUsuńOstatnioDodanąBryłę.Enabled = true;
            pzbtnUsuńPierwsząBryłę.Enabled = true;
            pzbtnUsuńWybranąBryłę.Enabled = true;
            pzbtnWylosujNowePołożenie.Enabled = true;
            pzbtnNoweAtrybutyGraficzne.Enabled = true;
        }

        private void pzbtnNoweAtrybutyGraficzne_Click(object sender, EventArgs e)
        {
            Color pzKolorLinii;
            DashStyle pzStylLinii;
            int pzGrubośćLinii;
            pzRysownica.Clear(pzpbPowierzchniaGraficzna.BackColor);
            Random pzGenerujLiczbęLosową = new Random();

            for (int i = 0; i < pzLBG.Count; i++)
            {
                pzKolorLinii = Color.FromArgb(pzGenerujLiczbęLosową.Next(0, 255), pzGenerujLiczbęLosową.Next(0, 255), pzGenerujLiczbęLosową.Next(0, 255));
                pzStylLinii = pzWybórStylu(pzGenerujLiczbęLosową.Next(4));
                pzGrubośćLinii = pzGenerujLiczbęLosową.Next(1, 6);
                pzLBG[i].pzUstalAtrybutyGraficzne(pzKolorLinii, pzStylLinii, pzGrubośćLinii);
            }

            for (int i = 0; i < pzLBG.Count; i++)
                pzLBG[i].pzWykreśl(pzRysownica);
            pzpbPowierzchniaGraficzna.Refresh();
        }

        private void pzbtnWylosujNowePołożenie_Click(object sender, EventArgs e)
        {
            int pzXmax = pzpbPowierzchniaGraficzna.Width;
            int pzYmax = pzpbPowierzchniaGraficzna.Height;
            Random pzGenerujLiczbęLosową = new Random();
            pzRysownica.Clear(pzpbPowierzchniaGraficzna.BackColor);

            for (int i = 0; i < pzLBG.Count; i++)
            {
                int pzWspółrzędnaXPodłogiBryły = pzGenerujLiczbęLosową.Next(0, pzXmax);
                int pzWspółrzędnaYPodłogiBryły = pzGenerujLiczbęLosową.Next(0, pzYmax);
                pzLBG[i].pzPrzesuńDoNowegoXY(pzpbPowierzchniaGraficzna, pzRysownica, pzWspółrzędnaXPodłogiBryły, pzWspółrzędnaYPodłogiBryły);
            }
            pzpbPowierzchniaGraficzna.Refresh();
        }

        private void pzbtnKierunekObrotuPrawo_Click(object sender, EventArgs e)
        {
            pzKierunekObrotu = false;
        }

        private void pzbtnKierunekObrotuLewo_Click(object sender, EventArgs e)
        {
            pzKierunekObrotu = true;
        }

        private void pzbtnWłączSlajder_Click(object sender, EventArgs e)
        {
            if (pzLBG.Count > 0)
            {
                pzLBG.Sort();
            }
        }

        public void pzAlgorytmSelectSort(ref double[] pzT, int pzn)
        {
            int pzi, pzk, pzj;
            double pzPomocnicza;

            for (pzi = 0; pzi < pzn - 1; pzi++)
            {
                pzk = pzi;
                for (pzj = pzi + 1; pzj < pzn; pzj++)
                    if (pzT[pzk] > pzT[pzj])
                        pzk = pzj;
                pzPomocnicza = pzT[pzi];
                pzT[pzi] = pzT[pzk];
                pzT[pzk] = pzPomocnicza;
            }
        }

        private void pzbtnUsuńWybranąBryłę_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(pznumBryłaDoUsunięcia.Value.ToString());

            if (i < 0 || i > pzLBG.Count || i == pzLBG.Count)
            {
                errorProvider1.SetError(pzbtnUsuńWybranąBryłę, "Nieprawidłowy index bryły");
                return;
            }
            errorProvider1.Dispose();
            pzLBG.RemoveAt(i);
            pzRysownica.Clear(pzpbPowierzchniaGraficzna.BackColor);
        }

        private void pzbtnUsuńOstatnioDodanąBryłę_Click(object sender, EventArgs e)
        {
            if (pzLBG.Count < 1)
            {
                errorProvider1.SetError(pzbtnUsuńOstatnioDodanąBryłę, "Brak czegokolwiek na powierzchni graficznej");
                return;
            }
            errorProvider1.Dispose();
            pzLBG.RemoveAt(pzLBG.Count - 1);
            pzRysownica.Clear(pzpbPowierzchniaGraficzna.BackColor);
        }

        private void pzbtnUsuńPierwsząBryłę_Click(object sender, EventArgs e)
        {
            if (pzLBG.Count < 1)
            {
                errorProvider1.SetError(pzbtnUsuńPierwsząBryłę, "Brak czegokolwiek na powierzchni graficznej");
                return;
            }
            errorProvider1.Dispose();
            pzLBG.RemoveAt(0);
            pzRysownica.Clear(pzpbPowierzchniaGraficzna.BackColor);
        }

        private void pztextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
