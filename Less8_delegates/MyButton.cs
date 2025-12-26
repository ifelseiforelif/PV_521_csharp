
namespace Less8_delegates;

public delegate void ButtonHandler();
internal class MyButton
{
    public event ButtonHandler evClick;
    public void OnClick()
    {
        evClick?.Invoke();
    }
}
