/*
 * Created by Ranorex
 * User: dotrongnhanlqa
 * Date: 5/7/2021
 * Time: 1:07 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1
{
	/// <summary>
	/// A collection of useful validation helper methods.
	/// </summary>
	[UserCodeCollection]
	public static class Utils
	{
	//Code use for DBC3-IDE	
		
		// Code use for login function
		/// <summary>
		/// Logout and click item login
		/// </summary>
		/// <param name="iconUser"></param>
		/// <param name="itemLogin"></param>
		/// <param name="itemLogout"></param>
		/// <param name="duration"></param>
		[UserCodeMethod]
		public static void logoutAndClickLogin(RepoItemInfo iconUser, RepoItemInfo itemLogin, RepoItemInfo itemLogout, int duration)
		{
			Ranorex.Unknown btn;
			if (itemLogout.Exists<Ranorex.Unknown>(duration, out btn))
			{
				btn.Click();
				iconUser.CreateAdapter<Ranorex.Unknown>(true).Click();
				itemLogin.CreateAdapter<Ranorex.Unknown>(true).Click();
			}else
			{
				itemLogin.CreateAdapter<Ranorex.Unknown>(true).Click();
			}
		}
		
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="walletName"></param>
		/// <param name="name"></param>
		[UserCodeMethod]
		public static void validationAddNewDbcWallet(RepoItemInfo walletName, string name)
		{
			Ranorex.Unknown rxpath = walletName.CreateAdapter<Ranorex.Unknown>(true, 30000);
			Ranorex.Unknown newRxpath = rxpath.FindSingle("//option[@innertext='<value>'][1]".Replace("<value>", name), 30000);
			if (newRxpath.Visible == true) {
				Report.Success("Success.");
			}else{
				Report.Error("Element does not exist.");
			}
		}
		
		
		
	//Code use for DNCWAREBlockChain3
		[UserCodeMethod]
		public static string nameToID(RepoItemInfo name, string domain)
		{
			string nameValue = name.CreateAdapter<Ranorex.Unknown>(true, 30000).Element.GetAttributeValue("InnerText").ToString();
			nameValue = nameValue.Replace(domain,"");
			return nameValue;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[UserCodeMethod]
		public static string formatId (RepoItemInfo id) {
			Ranorex.Unknown idElement = id.CreateAdapter<Ranorex.Unknown>(true, 30000);
			string value = idElement.Element.GetAttributeValue("InnerText").ToString();
			value = value.Replace("\"", "");
			return value;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="domain"></param>
		/// <param name="domainName"></param>
		[UserCodeMethod]
		public static void chooseDomain(RepoItemInfo domain, string	domainName)
		{
			IList<Ranorex.Unknown> listDomainName = domain.CreateAdapters<Ranorex.Unknown>(30000);
			foreach (var element in listDomainName) 
			{
				string name = element.Element.GetAttributeValue("InnerText").ToString();
				if(name == domainName)
				{
					element.Click();
					break;
				}
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="domain"></param>
		/// <param name="domainName"></param>
		/// <param name="user"></param>
		[UserCodeMethod]
		public static void chooseUser(RepoItemInfo domain, string domainName, string user)
		{
			string nameUser = user + domainName;
			IList<Ranorex.Unknown> listDomainName = domain.CreateAdapters<Ranorex.Unknown>(30000);
			foreach (var element in listDomainName) 
			{
				string name = element.Element.GetAttributeValue("InnerText").ToString();
				if(name == nameUser)
				{
					element.Click();
					break;
				}
			}
		}
		/// <summary>
		/// logout and login
		/// </summary>
		/// <param name="logout"></param>
		/// <param name="buttonOK"></param>
		/// <param name="walletFile"></param>
		/// <param name="duration"></param>
		[UserCodeMethod]
		public static void logoutAndLogin(RepoItemInfo logout, RepoItemInfo buttonOK, RepoItemInfo walletFile, int duration)
		{
			Ranorex.Unknown btn;
			if (walletFile.Exists<Ranorex.Unknown>(duration, out btn))
			{
				btn.Click();
			}else
			{
				logout.CreateAdapter<Ranorex.Unknown>(true).Click();
				buttonOK.CreateAdapter<Ranorex.Unknown>(true).Click();
				Thread.Sleep(5000);
				walletFile.CreateAdapter<Ranorex.Unknown>(true).Click();
			}
		}
		
		/// <summary>
		/// Click vao the button
		/// </summary>
		/// <param name="button">Element can click</param>
		[UserCodeMethod]
		public static void clickButton(RepoItemInfo button)
		{
			button.CreateAdapter<Ranorex.Unknown>(true).Click();
		}
		
		/// <summary>
		/// Kiem tra neu element ton tai va click
		/// </summary>
		/// <param name="button">Element can click</param>
		/// <param name="duration">Thoi gian (milisecond) tim element</param>
		[UserCodeMethod]
		public static void clickElementIfExisted(RepoItemInfo button, int duration)
		{
			Ranorex.Unknown btn;
			if (button.Exists<Ranorex.Unknown>(duration, out btn))
			{
				btn.Click();
			}
		}
		
		/// <summary>
		/// Chon gia tri tu dropdown
		/// </summary>
		/// <param name="selectTag"></param>
		/// <param name="value"></param>
		[UserCodeMethod]
		public static void selectOptionFromDropdown(RepoItemInfo selectTag, string value)
		{
			SelectTag tag = selectTag.CreateAdapter<Ranorex.SelectTag>(true);
			OptionTag option = tag.FindSingle("//option[@innertext~'<value>']".Replace("<value>", value), 30000);
			option.Selected = true;
		}
	}
}
