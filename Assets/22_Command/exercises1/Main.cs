using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command_exercises1;
using CommandPattern_drawer_exercises1;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace CommandPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        public MacroCommand history = new MacroCommand();
        public Button clearButton;
        public Button redButton;
        public Button greenButton;
        public Button blueButton;
        public DrawCanvas canvas;

        void Start()
        {
            canvas.CanvasStart(400, 400, history);
            clearButton.onClick.AddListener(() => { actionPerformed(clearButton); });
            redButton.onClick.AddListener(() => { actionPerformed(redButton); });
            greenButton.onClick.AddListener(() => { actionPerformed(greenButton); });
            blueButton.onClick.AddListener(() => { actionPerformed(blueButton); });
        }

        public void Update()
        {
            // 左ボタンクリック
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Input.mousePosition;
                Debug.Log("LeftClick:" + mousePosition);
                Command cmd = new DrawCommand(canvas, mousePosition);
                history.append(cmd);
                cmd.Execute();
            }
        }

        public void actionPerformed(Object button)
        {
            if (button == clearButton)
            {
                Debug.Log("クリア");
                history.clear();
                Scene loadScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(loadScene.name);
            }else if(button == redButton)
            {
                Debug.Log("赤色");
                Command cmd = new ColorCommand(canvas, Color.red);
                history.append(cmd);
                cmd.Execute();
            }else if(button == greenButton)
            {
                Debug.Log("緑色");
                Command cmd = new ColorCommand(canvas, Color.green);
                history.append(cmd);
                cmd.Execute();
            }else if(button == blueButton)
            {
                Debug.Log("青色");
                Command cmd = new ColorCommand(canvas, Color.blue);
                history.append(cmd);
                cmd.Execute();
            }
        }

    }
}
