﻿using RTS;
using System;
using UnityEngine;
using UnityEngine.Networking;

public class MultiplayerMenu : Menu
{
	protected override void SetButtons()
	{
		buttons = new string[] { "LAN Host", "LAN Cient", "LAN Server Only", "Main Menu" };
	}

	protected override void HandleButton(string text)
	{
		base.HandleButton(text);
		switch (text)
		{
			case "LAN Host": LANHost(); break;
			case "LAN Cient": LANCient(); break;
			case "LAN Server Only": LANServerOnly(); break;
			case "Main Menu": MainMenu(); break;
			default: break;
		}
	}

	private void LANHost()
	{
		ResourceManager.MenuOpen = false;
		Time.timeScale = 1.0f;
		GetNetworkManager().StartHost();
	}

	private void LANCient()
	{
		ResourceManager.MenuOpen = false;
		Time.timeScale = 1.0f;
		GetNetworkManager().StartClient();
	}

	private void LANServerOnly()
	{
		ResourceManager.MenuOpen = false;
		Time.timeScale = 1.0f;
		GetNetworkManager().StartServer();
	}

	private void MainMenu()
	{
		GetComponent<MultiplayerMenu>().enabled = false;
		GetComponent<MainMenu>().enabled = true;
	}
}