using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ProjetoGoogle
{
    [TestClass]
    public class UnitTest1{



        [TestMethod]
        public void TestMethod1(){

            By gmail = By.Name("user");
            By senha = By.Id("pass");
            By logar = By.Name("commit");
            By botao = By.Id("menuBotao");
            

            WebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://portal.ucsal.br/");

            //Escrevendo o email 
            webDriver.FindElement(gmail).SendKeys("Matricula");
            //Colocando a senha 
            webDriver.FindElement(senha).SendKeys("senha");
            //
            webDriver.FindElement(logar).Click();

            webDriver.FindElement(botao).Click();




        }
    }
}
