using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My.Game
{
    using My.Core;
    public class Game : MonoBehaviourSingleton<Game>
    {
        public World World;

        private void Start()
        {
            //todo �ӽ�. .�� �� SceneTransition �۾��ϸ� ����
            SceneStart();
        }

        public void SceneStart()
        {
            if(World == null)
                World = new World();

            World.Init();
        }
    }
}