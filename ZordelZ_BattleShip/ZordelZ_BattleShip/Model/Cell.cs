using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZordelZ_BattleShip.Model
{
    public enum StateEnum { SEA, SHIP, HIT, MISS };
    public class Cell : INotifyPropertyChanged
    {

        //public StateEnum State
        //{
            
        //    get
        //    {
        //        return stateEnum;
        //    }
        //    set
        //    {
        //        stateEnum = value;
        //        FieldChanged();
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }
        public void Clicked(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //State = !State;
        }
    }
}
