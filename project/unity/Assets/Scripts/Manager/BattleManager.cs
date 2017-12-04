﻿using System;

using Model;

using UnityEngine;
using UnityEngine.UI;


namespace Manager {

    public class BattleManager : MonoBehaviour {

        private Hero _hero;
        private HandsArea handsArea;
        public UCard _ucard;

        public Button EndHeroTurnBtn;
        
        public Hero Hero {
            get { return _hero; }
            set { _hero = value; }
        }

        private void initHandsArea() {
            foreach(var card in _hero.Deck) {
                Console.WriteLine("load card: " + card.Name);
                handsArea.AddCard(card);
            }
        }

        void Start() {
            Hero = transform.GetComponentInChildren<Hero>();
            handsArea = transform.GetComponentInChildren<HandsArea>();
            handsArea.battleManager = this;
            _ucard = transform.GetComponentInChildren<UCard>();
            handsArea.tempUCard = _ucard;
            initHandsArea();
        }

        
        
    }

}