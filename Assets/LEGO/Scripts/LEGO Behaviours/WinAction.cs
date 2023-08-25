using Unity.LEGO.Game;
using Unity.LEGO.Behaviours.Triggers;

namespace Unity.LEGO.Behaviours.Actions
{
    public class WinAction : ObjectiveAction
    {
        public override ObjectiveConfiguration GetDefaultObjectiveConfiguration(Trigger trigger)
        {
            ObjectiveConfiguration result = new ObjectiveConfiguration();

            if (trigger)
            {
                var triggerType = trigger.GetType();
                if (triggerType == typeof(PickupTrigger))
                {
                    result.Title = "Recoge todas las camionetas";
                    result.Description = "¡Ve a buscarlos!";
                    result.ProgressType = ObjectiveProgressType.Amount;
                }
                else if (triggerType == typeof(TouchTrigger))
                {
                    result.Title = "Toca el objeto";
                    result.Description = "¡Tócalo!";
                }
                else if (triggerType == typeof(NearbyTrigger))
                {
                    result.Title = "Llegar al objetivo";
                    result.Description = "¡Ir allí!";
                }
                else if (triggerType == typeof(TimerTrigger))
                {
                    result.Title = "Sobrevivir";
                    result.Description = "¡Cuelga ahí!";
                    result.ProgressType = ObjectiveProgressType.Time;
                }
                else if (triggerType == typeof(RandomTrigger))
                {
                    result.Title = "Sobrevive por un tiempo aleatorio";
                    result.Description = "¡Cuelga ahí!";
                }
                else if (triggerType == typeof(InputTrigger))
                {
                    result.Title = "Press the Button";
                    result.Description = "¡Empujalo!";
                }
                else if (triggerType == typeof(CounterTrigger))
                {
                    result.Title = "Completa el objetivo";
                    result.Description = "¡Hazlo!";
                }
                else
                {
                    result.Title = "Completa el objetivo";
                    result.Description = "¡Hazlo!";
                }
            }
            else
            {
                result.Title = "Easy as Pie!";
                result.Description = "Conecte un Trigger Brick al Win Brick para hacer que este objetivo sea más desafiante.";
            }

            return result;
        }

        protected override void Reset()
        {
            base.Reset();

            m_IconPath = "Assets/LEGO/Gizmos/LEGO Behaviour Icons/Win Action.png";
        }
    }
}
