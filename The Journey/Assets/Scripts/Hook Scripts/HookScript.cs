using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour {

    [SerializeField]
    private Transform itemHolder;

    private bool itemAttached;

    private HookMovement hookMovement;

    private PlayerAnimation playerAnim;

    void Awake() {
        hookMovement = GetComponentInParent<HookMovement>();
        playerAnim = GetComponentInParent<PlayerAnimation>();
    }

    void OnTriggerEnter2D(Collider2D target) {

        if(target.tag == Tags.SMALL_GOLD || target.tag == Tags.MIDDLE_GOLD ||
            target.tag == Tags.LARGE_GOLD || target.tag == Tags.LARGE_STONE ||
            target.tag == Tags.MIDDLE_STONE) {

            itemAttached = true;

            target.transform.parent = itemHolder;
            target.transform.position = itemHolder.position;

            hookMovement.move_Speed = target.GetComponent<ItemScript>().hook_Speed;

            hookMovement.HookAttachedItem();

            // animate player
            playerAnim.PullingItemAnimation();

            if (target.tag == Tags.SMALL_GOLD || target.tag == Tags.MIDDLE_GOLD ||
                target.tag == Tags.LARGE_GOLD) {

                 SoundManager.instance.HookGrab_Gold();

            } else if (target.tag == Tags.MIDDLE_STONE || target.tag == Tags.LARGE_STONE) {

                 SoundManager.instance.HookGrab_Stone();

            }

            SoundManager.instance.PullSound(true);

        } // if target is an item

        if(target.tag == Tags.DELIVER_ITEM) { 

            if(itemAttached) {

                itemAttached = false;

                Transform objChild = itemHolder.GetChild(0);

                objChild.parent = null;
                objChild.gameObject.SetActive(false);

                playerAnim.IdleAnimation();
                SoundManager.instance.PullSound(false);

            }

        } // deliver item

    } // on trigger enter


} // class
































