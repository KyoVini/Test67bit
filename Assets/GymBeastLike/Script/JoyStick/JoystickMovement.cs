using UnityEngine;
using UnityEngine.EventSystems;

namespace GymBeastLike
{
    [RequireComponent(typeof(EventTrigger))]
    public class JoystickMovement : MonoBehaviour
    {
        private GameObject joystick;
        private GameObject joystickbg;
        private Vector2 joystickvec;
        private Vector2 joysticktouchpos;
        private Vector2 joystickoriginalpos;
        private float joystickradius;
        EventTrigger eventtrigger;

        void Awake()
        {
            joystickbg = transform.Find("bg").gameObject;
            joystick = transform.Find("joystick").gameObject;
            joystickoriginalpos = joystick.transform.position;
            joystickradius = joystickbg.GetComponent<RectTransform>().sizeDelta.y / 4;

            eventtrigger = gameObject.GetComponent<EventTrigger>();
            if (eventtrigger == null)
            {
                eventtrigger = gameObject.AddComponent<EventTrigger>();
            }

            AddEvent(EventTriggerType.PointerDown, PointerDown);
            AddEvent(EventTriggerType.Drag, Drag);
            AddEvent(EventTriggerType.PointerUp, PointerUP);
        }
        public void PointerDown(BaseEventData data)
        {
            joystick.transform.position = Input.mousePosition;
            joystickbg.transform.position = Input.mousePosition;
            joysticktouchpos = Input.mousePosition;
        }
        public void Drag(BaseEventData _baseeventdata)
        {
            PointerEventData pointereventdata = _baseeventdata as PointerEventData;
            Vector2 dragpos = pointereventdata.position;
            joystickvec = (dragpos - joysticktouchpos).normalized;

            float jsdist = Vector2.Distance(dragpos, joysticktouchpos);

            if (jsdist < joystickradius)
            {
                joystick.transform.position = joysticktouchpos + joystickvec * jsdist;
            }
            else
            {
                joystickvec = joystickvec.normalized * joystickradius;
                joystick.transform.position = joysticktouchpos + joystickvec;
                //joystick.transform.position = joysticktouchpos + joystickvec * joystickradius;
            }
        }

        public void PointerUP(BaseEventData data)
        {
            joystickvec = Vector2.zero;
            joystick.transform.position = joystickoriginalpos;
            joystickbg.transform.position = joystickoriginalpos;
        }
        private void AddEvent(EventTriggerType eventType, UnityEngine.Events.UnityAction<BaseEventData> action)
        {
            EventTrigger.Entry entry = new EventTrigger.Entry
            {
                eventID = eventType
            };
            entry.callback.AddListener(action);
            eventtrigger.triggers.Add(entry);
        }
        private void FixedUpdate()
        {
            if (CharacterManager.Instance.GetControlable())
            {
                Vector2 normalizedJoystickVec = joystickvec.normalized;
                float h = normalizedJoystickVec.x;
                float v = normalizedJoystickVec.y;

                GameManager.Instance.GameControl(h, v);
            }
        }
    }
}
