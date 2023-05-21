using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12
{
    class CCurso
    {
        private string curso;
        private int id;

        public CCurso(string pCurso, int pID)
        {
            curso = pCurso;
            id = pID;
        }

        public string Curso { get => curso; set => curso = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Curso => {0}", curso);
        }
    }
}
