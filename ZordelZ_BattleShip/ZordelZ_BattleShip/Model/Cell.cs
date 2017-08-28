using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZordelZ_BattleShip.Model
{
    public enum StateEnum { SEA, SHIP, HIT, MISS};
    public class Cell : INotifyPropertyChanged
    {
        private StateEnum state;
        public int State
        {

            get
            {
                int type = 0;
                switch (state)
                {
                    case StateEnum.SEA:
                        type = 1;
                        break;
                    case StateEnum.SHIP:
                        type = 2;
                        break;
                    case StateEnum.HIT:
                        type = 3;
                        break;
                    case StateEnum.MISS:
                        type = 4;
                        break;
                }
                return type;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        state = StateEnum.SEA;
                        break;
                    case 2:
                        state = StateEnum.SHIP;
                        break;
                    case 3:
                        state = StateEnum.HIT;
                        break;
                    case 4:
                        state = StateEnum.MISS;
                        break;
                }
                FieldChanged();
            }
        }

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
            
        }
    }
}
