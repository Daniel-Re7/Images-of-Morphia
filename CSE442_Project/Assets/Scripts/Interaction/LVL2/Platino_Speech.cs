﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platino_Speech : MonoBehaviour
{
    public TextBoxManager textBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(Wait(1));
            textBox.EnableText();
        }
    }

    public void Disapper()
    {
        Destroy(gameObject);
    }

    IEnumerator Wait(float timer)
    {
        yield return new WaitForSecondsRealtime(timer);
    }
}