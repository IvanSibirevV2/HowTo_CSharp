using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Model
{
    public class TestS
    {
        public List<Test> ListTest = new List<Test>();
        System.Windows.Controls.StackPanel _View = null;
        /// <summary></summary>
        /// <param name="_StackPanel">Элемент в который ввязывается тест</param>
        /// <returns></returns>
        public TestS Init(
            System.Windows.Controls.StackPanel _StackPanel
            )
        {
            ;
            _View = _StackPanel;
            List<List<string>> _ListListString = new SQL("SELECT Id,Text from Test;").ExecuteReader();
            _ListListString
                .ForEach(_TestRow=>
                    ListTest.Add(new Test(Convert.ToInt32(_TestRow[0]), _TestRow[1])
                        .Init()
                    )
                );
            ListTest.ForEach(_Test => _View.Children.Add(_Test._View));
            return this;
        }
    }
}
