﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistMeProject.Models
{
    public class SearchDocument : IComparable<SearchDocument>
    {
        public double Score { get; set; }

        public ISearchable Value { get; private set; }

        public SearchDocument(ISearchable value)
        {
            Score = 0;
            this.Value = value;
        }

        public Dictionary<string, int> GetTermFrequencies()
        {
<<<<<<< HEAD
            var text = value.GetDocumentText();
=======
            var text = Value.GetDocumentText();
>>>>>>> upstream/master
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            foreach (String word in words)
            {
<<<<<<< HEAD
                if(frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
=======
                string w = word.ToUpper();
                if(frequencies.ContainsKey(w))
                {
                    frequencies[w]++;
                }
                else
                {
                    frequencies[w] = 1;
>>>>>>> upstream/master
                }
            }
            return frequencies;
        }

        public int GetWordsCount()
        {
            int count = 0;
<<<<<<< HEAD
            var text = value.GetDocumentText();
=======
            var text = Value.GetDocumentText();
>>>>>>> upstream/master
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));
            foreach (String word in words)
            {
                count++;
            }
            return count;
        }

        public int CompareTo(SearchDocument other)
        {
<<<<<<< HEAD
            int val = Score.CompareTo(other.Score);
            if (val == 0 && value is IComparable)
                return ((IComparable)value).CompareTo(other.value);
            else
                return val;
        }
=======
            int val = -Score.CompareTo(other.Score);
            if (val == 0 && Value is IComparable)
                return ((IComparable)Value).CompareTo(other.Value);
            else
                return val;
        }

        public override string ToString()
        {
            return Value.ToString()+" - Score: "+Score;
        }

>>>>>>> upstream/master
    }
}
