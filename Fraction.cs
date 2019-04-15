using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur = 1;

        public static Fraction operator +(Fraction left, int dRight)
        {
            Fraction right = new Fraction(dRight);
            return left.Plus(right);
        }
        public static Fraction operator +(int dleft, Fraction right)
        {
            Fraction left = new Fraction(dleft);
            return left.Plus(right);

        }
        public static Fraction operator +(Fraction left, Fraction right)
        {
            return left.Plus(right);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            return left.Moins(right);
        }
        public static Fraction operator -(Fraction left, int dRight)
        {
            Fraction right = new Fraction(dRight);
            return left.Moins(right);
        }
        public static Fraction operator -(int dleft, Fraction right)
        {
            Fraction left = new Fraction(dleft);
            return left.Moins(right);
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return left.Multiplie(right);
        }
        public static Fraction operator *(Fraction left, int dRight)
        {
            Fraction right = new Fraction(dRight);
            return left.Multiplie(right);
        }
        public static Fraction operator *(int dleft, Fraction right)
        {
            Fraction left = new Fraction(dleft);
            return left.Multiplie(right);
        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
            return left.Divise(right);
        }
        public static Fraction operator /(Fraction left, int dRight)
        {
            Fraction right = new Fraction(dRight);
            return left.Divise(right);
        }
        public static Fraction operator /(int dleft, Fraction right)
        {
            Fraction left = new Fraction(dleft);
            return left.Divise(right);
        }

        public Fraction()
        {
            numerateur = 0;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            numerateur = _numerateur;
            denominateur = _denominateur;
        }

        public Fraction(int _numerateur)
        {
            numerateur = _numerateur;
        }

        public String GetString()
        {
            return (numerateur.ToString() + "/" + denominateur.ToString());
        }

        public void Oppose()
        {
            numerateur = -numerateur;
        }

        public void Inverse()
        {
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        public bool SuperieurA(Fraction _f)
        {
            return numerateur / denominateur == _f.numerateur / _f.numerateur;
        }

        public bool EgalA(Fraction _f)
        {
            Fraction f1 = new Fraction(numerateur, denominateur);
            Fraction f2 = new Fraction(_f.numerateur, _f.denominateur);
            f1.Reduire();
            f2.Reduire();
            return (f1.denominateur == f2.denominateur) && (f1.numerateur == f2.numerateur);
        }
        public int GetPgcd()
        {
            int a = numerateur;
            int b = denominateur;
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public void Reduire()
        {
            int pgcd = GetPgcd();
            numerateur /= pgcd;
            denominateur /= pgcd;
        }

        public Fraction Plus(Fraction f)
        {
            
            int f1Den = denominateur * f.denominateur;
            int f1Num = numerateur * f.denominateur + f.numerateur * denominateur;
            Fraction f2 = new Fraction(f1Num, f1Den);
            f2.Reduire();
            return f2;

        }
        public Fraction Moins(Fraction f)
        {

            int f1Den = denominateur * f.denominateur;
            int f1Num = numerateur * f.denominateur - f.numerateur * denominateur;
            Fraction f2 = new Fraction(f1Num, f1Den);
            f2.Reduire();
            return f2;

        }
        public Fraction Multiplie(Fraction f)
        {
            Fraction f2 = new Fraction(numerateur * f.numerateur, denominateur * f.denominateur);
            f2.Reduire();
            return f2;

        }
        public Fraction Divise(Fraction f)
        {
            Fraction f2 = new Fraction(numerateur * f.denominateur, denominateur * f.numerateur);
            f2.Reduire();
            return f2;
        }
    }
}