using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Faizan.Game.Systems;

namespace Faizan.Game.Character
{
    
    internal class Player : Character
    {

        #region VARIABLE

        public PlayerMovement playerMovement;
        #endregion

        #region UNITY
        private void Awake()
        {
            MovementInitialize();
        }

        #endregion




        #region MECHANICS
        private void MovementInitialize()
        {
            if (TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
            {
                if (this.playerMovement == null)
                {
                    this.playerMovement = playerMovement;
                }
            }
            else
            {
                this.playerMovement = gameObject.AddComponent<PlayerMovement>();
            }
        }

        #endregion









    }
}


