using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinPT.Model
{
    class Kanji
    {
        private int id;
        private string literal;
        private int grade;
        private int freq;
        private string on_reading;
        private string kun_reading;
        private string meaning;

        public Kanji()
        {

        }
        public Kanji(int id, string literal, int grade, int freq, string on_reading, string kun_reading, string meaning)
        {
            this.Id = id;
            this.Literal = literal;
            this.Grade = grade;
            this.Freq = freq;
            this.On_reading = on_reading;
            this.Kun_reading = kun_reading;
            this.Meaning = meaning;
        }

        public int Id { get => id; set => id = value; }
        public string Literal { get => literal; set => literal = value; }
        public int Grade { get => grade; set => grade = value; }
        public int Freq { get => freq; set => freq = value; }
        public string On_reading { get => on_reading; set => on_reading = value; }
        public string Kun_reading { get => kun_reading; set => kun_reading = value; }
        public string Meaning { get => meaning; set => meaning = value; }

    }
}
