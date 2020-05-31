using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command;
using CommandPattern_drawer;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace CommandPattern
{
    public class Main : MonoBehaviour
    {
        public MacroCommand history = new MacroCommand();
        public Button clearButton;
        public DrawCanvas canvas;

        void Start()
        {
            canvas.CanvasStart(400, 400, history);
            clearButton.onClick.AddListener(() => { actionPerformed(); });
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

        public void actionPerformed()
        {
            Debug.Log("クリア");
            history.clear();
            Scene loadScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadScene.name);
        }
    }
}
