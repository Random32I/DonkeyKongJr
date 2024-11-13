[Video Explanation](https://youtu.be/QmYsq2tlTss)

# Written Explanation
We decided to use a DLL to change the speed of the player. The DLL plugin itself contains a singleton class named SpeedChanger, which the plugin tester monobehaviour accesses on runtime to get a function to change the speed of the player. The function can be changed within the DLL to set different speeds. In the provided builds, one of them contains a DLL that sets the speed to 2 times, while the other sets the speed to 200 times.

# Diagram
![image](https://github.com/user-attachments/assets/660fe8b9-fc84-4cfa-8c0d-984cbb0cebd1)

# DLL Code (Proof of Singleton)
```C#
namespace DKDLLActivity
{
    public class SpeedChanger
    {
        private static SpeedChanger _instance;

        public static SpeedChanger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeedChanger();
                }
                return _instance;
            }
        }
        public float Execute(float speed)
        {
            speed = speed * 200;
            return speed;
        }
    }
}
```
