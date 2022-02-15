using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class UnityChanController : MonoBehaviour
{
    [SerializeField] FixedJoystick m_FixedJoystick;
    [SerializeField] Animator m_Animator;
    [SerializeField] float m_Speed  = 10;
    private CharacterController m_Controller;
    private Vector3 m_Direction;
    
    void Start()
    {
        m_Controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {

        if(m_Direction != new Vector3(0, 0, 0))
        {
            transform.localRotation = Quaternion.LookRotation(m_Direction);
        }
        m_Animator.SetFloat("isMoving", Mathf.Max(Mathf.Abs(m_Direction.x), Mathf.Abs(m_Direction.z)));

        m_Controller.Move(m_Direction * m_Speed * Time.deltaTime);
    }

    public void FixedUpdate ()
    {
        m_Direction = Vector3.forward * m_FixedJoystick.Vertical + Vector3.right * m_FixedJoystick.Horizontal;
    }
}