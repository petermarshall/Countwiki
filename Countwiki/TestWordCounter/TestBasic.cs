using Countwiki.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWordCounter
{
    [TestClass]
    public class TestBasic
    {
        /// <summary>
        /// No <body> tag found return zero
        /// </summary>
        [TestMethod]
        public void TestCountNoBody()
        {
            WordCounter wordCounter = new WordCounter();

            int result = wordCounter.Count("xxx");

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestCountOneWordBasic()
        {
            WordCounter wordCounter = new WordCounter();

            int result = wordCounter.Count("<html><body>xxx</body></html>");

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void TestCountDistinctComplex()
        {
            WordCounter wordCounter = new WordCounter();

            int result = wordCounter.Count(ComplexHtml());

            Assert.IsTrue(result == 1114);
        }


        private string ComplexHtml()
        {
            return @"
<html><head>
    <title>CV – P33tr – Notes</title>
    <!-- Begin Jekyll SEO tag v2.6.1 -->
<title>CV | P33tr</title>
<meta name=""generator"" content=""Jekyll v3.9.0"">
< meta property = ""og:title"" content = ""CV"" >
   < meta name = ""author"" content = ""Peter Marshall"" >
      < meta property = ""og:locale"" content = ""en_US"" >
         < meta name = ""description"" content = ""Notes"" >
            < meta property = ""og:description"" content = ""Notes"" >
               < link rel = ""canonical"" href = ""https://petermarshall.github.io/blog//blog/cv/"" >
                  < meta property = ""og:url"" content = ""https://petermarshall.github.io/blog//blog/cv/"" >
                     < meta property = ""og:site_name"" content = ""P33tr"" >
                        < script async = """" src = ""//www.google-analytics.com/analytics.js"" ></ script >< script type = ""application/ld+json"" >
{ ""@type"":""WebPage"",""author"":{ ""@type"":""Person"",""name"":""Peter Marshall""},""headline"":""CV"",""url"":""https://petermarshall.github.io/blog//blog/cv/"",""description"":""Notes"",""@context"":""https://schema.org""}</ script >
  < !--End Jekyll SEO tag-- >
  

          < meta charset = ""utf-8"" >
   
       < meta content = ""text/html; charset=utf-8"" http - equiv = ""Content-Type"" >
      
          < meta http - equiv = ""X-UA-Compatible"" content = ""IE=edge"" >
           
               < meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0, maximum-scale=1.0"" >
              


                  < meta name = ""description"" content = ""Notes"" >
                 
                     < meta property = ""og:description"" content = ""Notes"" >
                    

                        < meta name = ""author"" content = ""P33tr"" >
                       


                           < meta property = ""og:title"" content = ""CV"" >
                          
                              < meta property = ""twitter:title"" content = ""CV"" >
                             



                                 < meta property = ""og:image"" content = ""https://petermarshall.github.io/blog//images/peter.png"" >
                                
                                    < meta property = ""twitter:image"" content = ""https://petermarshall.github.io/blog//images/peter.png"" >
                                   

                                       < meta property = ""og:site_name"" content = ""Peter Marshall - Software Developer"" >
                                      


                                          < link rel = ""stylesheet"" type = ""text/css"" href = ""/blog/assets/style.css"" >
                                           
                                               < link rel = ""alternate"" type = ""application/rss+xml"" title = ""P33tr - Notes"" href = ""/blog/feed.xml"" >
                                                  
                                                      < link rel = ""canonical"" href = ""https://petermarshall.github.io/blog//cv/"" >
                                                     

                                                         < meta name = ""theme-color"" content = ""#000000"" >
                                                        
                                                            < link rel = ""icon"" type = ""image/png"" sizes = ""32x32"" href = ""/blog/images/favicon-32x32.png"" >
                                                               

                                                                   < meta author = ""https://petermarshall.github.io/blog/"" >
                                                                
                                                                    < meta name = ""keywords"" content = ""Peter Marshall, P33tr, resume, curriculum vitae, cv"" >
                                                                   
                                                                       < meta name = ""description"" content = ""Blogs links and CV of Peter Marshall"" >
                                                                      
                                                                        < !--OpenGraph-- >
                                                                      
                                                                        < meta property = ""og:title"" content = ""CV"" –= """" p33tr = """" notes = """" >
                                                                              
                                                                                < meta property = ""og:type"" content = ""document"" >
                                                                                 
                                                                                   < meta property = ""og:url"" content = ""https://petermarshall.github.io/blog/"" >
                                                                                    
                                                                                      < meta property = ""og:image"" content = ""https://petermarshall.github.io/blog/"" >
                                                                                       
                                                                                         < meta property = ""og:description"" content = ""Blogs links and CV of Peter Marshall"" >
                                                                                          

                                                                                            < !--Twitter specific-- >
                                                                                          
                                                                                            < meta name = ""twitter:card"" content = ""summary"" >
                                                                                             
                                                                                               < meta name = ""twitter:url"" content = ""https://petermarshall.github.io/blog/"" >
                                                                                                
                                                                                                  < meta name = ""twitter:title"" content = ""CV"" –= """" p33tr = """" notes = """" >
                                                                                                        
                                                                                                          < meta name = ""twitter:description"" content = ""Blogs links and CV of Peter Marshall"" >
                                                                                                           
                                                                                                             < meta name = ""twitter:image"" content = ""https://petermarshall.github.io/blog/"" >
                                                                                                              
                                                                                                                </ head >
                                                                                                              

                                                                                                                <body>
                                                                                                              
                                                                                                                  < div id = ""bar"" ></ div >
                                                                                                               
                                                                                                                   < div class=""wrapper-container"">
      <div class=""wrapper-masthead"">
        <div class=""container"">
          <header class=""masthead clearfix"">
            <a href = ""/blog/"" class=""site-avatar""><img src = ""/blog/images/peter.png"" ></ a >
  

              < div class=""site-info"">
              <h1 class=""site-name""><a href = ""/blog/"" > P33tr </ a ></ h1 >
              < p class=""site-description"">Notes</p> 
            </div>

            <nav>
              <a href = ""/blog/"" > Home </ a >
              < a href=""/blog/links"">Links</a>
              <a href = ""/blog/search"" > Search </ a >
              < a href=""/blog/about"">About</a>
              <a href = ""/blog/cv"" > CV </ a >
            </ nav >
          </ header >
        </ div >
      </ div >

      < div class=""wrapper-main"">
        <div id = ""main"" role=""main"" class=""container"">
          <article class=""page"">

  <h1>CV</h1>

  <div class=""entry"">
    <h1 id = ""peter-marshall"" > Peter Marshall</h1>

<p>53 Great Clarendon st, Oxford, OX2 6AX, UK. <a href = ""mailto:marshall.peter@gmail.com"" > marshall.peter@gmail.com</a></p>

<p>Enterprise Application Developer with over 30 Years of experience as a contractor working on a wide variety of development projects.Working mostly in Public Utilities, Telecoms, Finance and Scientific Journal Publishing.</p>

<p><strong>Most recent Skills:</strong> ASP.NET MVC, C#, SQL Server, Postgresql, Web Services, Visual Studio, Agile, Scrum, REST, LINQ, TDD, BDD, EF. Javascript, Angular, React, GraphQL</p>

<h1 id=""recent-experience""> Recent Experience</h1>

<h4 id = ""senior-developer-contract"" > Senior Developer (contract)</h4>

<h2 id = ""uksbs-swindon"" > UKSBS(Swindon) </ h2 >
< p >< em > November 2018 - present</em></p>

<p><strong>Skills:</strong> DOTNET CORE, ASP.NET MVC, WEB API, C#, JavaScript, AWS, Micro services, Postgresql, Git, TDD, scrum, Okta, Jenkins, GraphQL, dapper, razor, BDDfy,rabbitMQ.</p>

<ul>
  <li>
    <p>Replacing the clients grant profiling and indexation services to enable them to de-couple from legacy 3rd party systems.</p>
  </li>
  <li>
    <p>Creating user interfaces for applications using razor and web services in asp.net webapi.</p>
  </li>
  <li>
    <p>Building these solutions from the ground up.Involved in all aspects of the development including selecting the development stack and technology.</p>
  </li>
  <li>
    <p>Coding complex financial spread calculations in C#. Deciphering existing stored procedures and building understanding where no documentation existed.</p>
  </li>
  <li>
    <p>As senior developer building up a development team and putting in place the software development process and toolset.Assisting the scrummaster to set up the scrum process and leading scrum retrospectives from time to time.</p>
  </li>
  <li>
    <p>Creating a successful migration process to transfer millions of existing grants to the new system without loss of data.</p>
  </li>
</ul>

<h4 id = ""senior-developer-contract-1"" > Senior Developer(contract)</h4>

<h2 id = ""schroders-asset-management-luxembourg"" > Schroders Asset Management(Luxembourg)</h2>
<p><em>July 2018 - October 2018</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, WEB API, C#, JavaScript, Azure, Service Fabric, React, Sql Server, GraphQl, NodeJS, TFS, TDD, scrum, Octopus Deploy</p>

<ul>
  <li>
    <p>Developing api end points in c# to serve up clients data though services deployed on azure service fabric.</p>
  </li>
  <li>
    <p>Operating out of Luxembourg, Working in a globally distributed team, managing build and deploy process in Octopus Deploy.</p>
  </li>
  <li>
    <p>The project was to supply a single source of truth for Schroders reporting data, as part of their digital strategy.</p>
  </li>
</ul>

<h4 id = ""developer-contract"" > Developer(contract) </ h4 >

< h2 id= ""sunquest-information-systems"" > Sunquest Information Systems</h2>
<p><em>July 2017 - July 2018</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, WEB API, C#, JavaScript, Angular, Sql Server, TFS, TDD, scrum, Entity Framework.</p>

<ul>
  <li>
    <p>Working right across this clients stack, from client side JavaScript (Angular), Server side code in C# and stored procedures in T-SQL on the Sql Server Database.</p>
  </li>
  <li>
    <p>Implementing user stories to add features to this clients application. The application manages patient test results and is used in over 70% of UK hospitals.</p>
  </li>
  <li>
    <p>Developed an application using electron and react, to query and update their database as a tool for assisting migration of data from one version of the application to another.</p>
  </li>
  <li>
    <p>Acting as scrum master and scrum mentor when required, specifically in leading the retrospectives.</p>
  </li>
</ul>

<h4 id = ""developer-contract-1"" > Developer(contract) </ h4 >

< h2 id= ""jp-morgan"" > JP Morgan</h2>
<p><em>March 2017 - July 2017</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, WEB API, C#, Javascript, typescript, Angular, Sql Server, Git, TDD, splunk, windows services, powershell, Jenkins.</p>

<ul>
  <li>
    <p>Developing Application Compute Cloud. An internal application to manage virtual machines running on the custom JP Morgan Cloud infrastructure.</p>
  </li>
  <li>
    <p>Updating the existing solution to comply with internal standards for software development.Implementing unit testing and dependency injection (unity).</p>
  </li>
  <li>
    <p>Developing new functionality across the stack from Angular, through the web api and database layers.</p>
  </li>
  <li>
    <p>Creating a log manager and adding logging to a webapi, and a management service. Log manager writes log info directly to splunk for analysis.</p>
  </li>
  <li>
    <p>Maintaining the continuous integration and deployment through Jenkins, writing scripts in powershell.</p>
  </li>
</ul>

<h4 id = ""developer-contract-2"" > Developer(contract) </ h4 >

< h2 id= ""ucas"" > UCAS </ h2 >
< p >< em > March 2015 - February 2017</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, WEB API, C#, Javascript, Angular, MySql, Git, NEventStore, Dapper, ElasticSearch, CQRS, AWS, Postgres, Fluent Migrator, MSPec, Scrum, TDD.</p>

<ul>
  <li>
    <p>Working as part of the Digital Acceleration team to completely re-write the online presence of this well respected public institution.This was a very big project with multiple scrum teams and a huge technology stack.Atlassian products were used to manage the development such as Bamboo, Jira, Bitbucket, Confluence and Hipchat.</p>
  </li>
  <li>
    <p>Initially working on the identity solution to provide single sign on for UCAS services.Interfacing with Gigya as a 3rd party for storage of data.Writing registration pages for password, email etc. Writing the server side REST api code in C#. Black box tests and unit tests.</p>
  </li>
  <li>
    <p>I worked on the provider management pages where universities update course and university data. Written in Angular with client side unit tests in jasmine and Karma.I set up the unit test framework including client side code coverage.</p>
  </li>
  <li>
    <p>In this contract I had to constantly learn new technologies and pushed my frontiers of knowledge into new areas such as document databases and AWS.</p>
  </li>
</ul>

<h4 id = ""developer-contract-3"" > Developer(contract) </ h4 >

< h2 id= ""royal-horticultural-society"" > Royal Horticultural Society</h2>
<p><em>August 2014 - February 2015</em></p>

<p><strong>Skills:</strong> ASP.NET MVC 5.0, WEB.API 2.0, C#, Javascript, SQL Server, TDD, MOQ, TFS, Angular, Bootstrap.</p>

<ul>
  <li>
    <p>This was a full stack role working in a small team using a scrum process to develop a Customer Relationship Management System, from the ground up.</p>
  </li>
  <li>
    <p>I was creating views and directives for this SPA.Working in HTML and javascript on the client side, creating controller code in the WEB.API layer in C# and writing WCF services. Also, db design and code of repository and data access layer, using linq and entity framework.</p>
  </li>
</ul>

<h4 id = ""developer-contract-4"" > Developer(contract) </ h4 >

< h2 id= ""cpa-global"" > CPA Global</h2>
<p><em>January 2014 - July 2014</em></p>

<p><strong>Skills:</strong> ASP.NET MVC 4, WEB.API, C#, Javascript, SQL Server, Oracle, Telerik Open Access, TDD, BDD, StoryQ, SVN, MOQ, Angular.js, Automapper, JIRA.</p>

<ul>
  <li>
    <p>Leading a small team to evolve this clients software architecture, writing a proof of concept that allowed the repository to be database agnostic, and opening up the front end to be accessible by a variety of clients by using JSON to interact with a WEB.API layer.</p>
  </li>
  <li>
    <p>Worked on features for the next version of the clients IP rights management software, writing c# on the server side.</p>
  </li>
</ul>

<h4 id = ""developer-contract-5"" > Developer(contract) </ h4 >

< h2 id= ""jp-morgan-chase"" > JP Morgan Chase</h2>
<p><em>August 2011 - December 2013</em></p>

<p><strong>Skills:</strong> ASP.NET MVC 3/4, C#, Razor, Javascript, SQL Server, Oracle, Entity Framework, WCF, .NET 4.5, TDD, MOQ, JQuery, Knockout.js, QPID, SPA, scrum, jira, cruisecontrol, svn.</p>

<ul>
  <li>
    <p>Working as part of the Global Technology Infrastructure dept.of this large investment bank.Creating solutions from functional requirements through to production implementation.This role involved working with a distributed development team, with testers in India, and analysts in the USA and management teams in Ireland.Responsible for design docs, code, unit tests, build process, and code management.</p>
  </li>
  <li>
    <p>Developed search pages for the internal Change management System.Developing web pages using Razor and JQuery, and server side code to take data from multiple WCF web services as well as Oracle and SQl Server data sources using Entity Framework.</p>
  </li>
  <li>
    <p>Worked on performance improvements for the whole code base. Refactoring code to take advantage of Entity Framework.Implemented a caching framework to reduce calls on the data sources. This role pushed my knowledge and ability, but in some instances web requests were reduced from 8 minutes to several seconds, and this was a very satisfying result.</p>
  </li>
  <li>
    <p>Developed a SPA for maintaining subscriptions to assets as part of a bigger change management solution.This application featured a complex attribute selection page and a search results page and was my first exposure to using knockout.js and the mvvm pattern in a client side environment.</p>
  </li>
  <li>
    <p>Developed server side components using WebAPI in ASP.NET MVC 4, using JSON to communicate with client side SPA.</p>
  </li>
</ul>

<h2 id = ""older-experience"" > Older Experience</h2>

<h4 id = ""developer-contract-6"" > Developer(contract) </ h4 >

< h2 id= ""doctors-chambers"" > Doctors Chambers</h2>
<p><em>Febuary 2011 - July 2011</em></p>

<p><strong>Skills:</strong> Silverlight, MVVMLight, WCF, ASP.NET, C#, SQL Server, .NET 4, TDD, SVN, Blend, Entity Framework, LINQ, WPF, Interlinq (RIA Services), MOQ, SQl Server Service Broker.</p>

<ul>
  <li>
    <p>As a senior developer I was providing guidance on architecture and development practices.Including giving a lead in tools and environments for TDD.</p>
  </li>
  <li>
    <p>Replacing the clients asp.net order entry system with a Silverlight application to gain performance improvements. I moved the team to using the MVVM pattern for Silverlight development.This has allowed the client to double the throughput of orders and re-allocate staff.</p>
  </li>
  <li>
    <p>I wrote a WPF application to extract emails and attachments from Outlook and transfer these to a SQL server database. In this process email and attachments were converted to XPS file format.</p>
  </li>
  <li>
    <p>Extracting business processes into WCF services.</p>
  </li>
</ul>

<h4 id = ""developer-contract-7"" > Developer(contract) </ h4 >

< h2 id= ""reed-business-information"" > Reed Business Information</h2>
<p><em>August 2010 - Janunary 2011</em></p>

<p><strong>Skills:</strong> WCF, ASP.NET, C#, SQL Server, .NET 3.5, TDD, MOQ, SSIS, Ecommerce, TFS, ELMAH, watin.</p>

<ul>
  <li>
    <p>Leading a small team to refactor and update the code for the clients credit card processing services. Providing guidance on development practices and scrum.</p>
  </li>
  <li>
    <p>Implemented DI on the WCF services, and broke out the code into layers so that it could be tested.</p>
  </li>
  <li>
    <p>This development was a refactoring of the RBI Ecommerce services for all credit card processing from RBI web sites. All credit card transactions for Reed are now channelled through this single WCF web service, where they are distributed across several card service providers.This is a highly secure and high volume solution.</p>
  </li>
  <li>
    <p>Implemented ELMAH as a unified logging system, across ASP.NET sites and WCF services.</p>
  </li>
</ul>

<h4 id = ""developer-contract-8"" > Developer(contract) </ h4 >

< h2 id= ""big-pink-new-media"" > Big Pink New Media</h2>
<p><em>January 2010 - July 2010</em></p>

<p><strong>Skills:</strong> ASP.NET MVC 2, C#, SQL Server, NHibernate, .NET 3.5, JQuery, Ninject, JSONP, TDD, MOQ, scrum, StoryQ, Sharepoint, Pair Programming.</p>

<ul>
  <li>
    <p>Developed RESTful web services in ASP.NET MVC.</p>
  </li>
  <li>
    <p>Developed components for building web sites for this new media agency.</p>
  </li>
  <li>
    <p>Developed Single Sign On components using Jquery and JSONP to allow sharing of information across domains using cookies.</p>
  </li>
  <li>
    <p>Wrote a utility to extract data from the sharepoint list webservice and transfer this to a sql server database.</p>
  </li>
  <li>
    <p>BDD using StoryQ was used as a demonstration environment for the Web Services.</p>
  </li>
  <li>
    <p>This was a scrum driven project to develop analytics services for pharmaceutical websites developed by a well respected new media agency.Working in a small team my role included code review, design, and refactoring.</p>
  </li>
</ul>

<h4 id = ""developer-contract-9"" > Developer(contract) </ h4 >

< h2 id= ""formula-one-management"" > Formula One Management</h2>
<p><em>September 2009 - January 2010</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, JQuery, C#, SQL Server, Linq to Sql, .NET 3.5, TDD, MOQ, scrum, Excel, DOCX.</p>

<ul>
  <li>
    <p>Design and develop an internal travel system web site.</p>
  </li>
  <li>
    <p>Working in a small development team acting as mentor on MVC pattern and TDD. Covering the full development life cycle and all aspects of the development from table design through to front end layout in CSS and JQuery.</p>
  </li>
  <li>
    <p>Wrote a reporting component that took data from Sql Server and created Excel Spreadsheets.</p>
  </li>
  <li>
    <p>Frequent interacting with system users to define requirements, and demonstrate ongoing development.</p>
  </li>
  <li>
    <p>A significant output from this project was a web design template illustrating best practices that the client could go on to use for future projects.</p>
  </li>
</ul>

<h4 id = ""developer-contract-10"" > Developer(contract) </ h4 >

< h2 id= ""idox-group-plc"" > IDOX Group Plc</h2>
<p><em>December 2008 - August 2009</em></p>

<p><strong>Skills:</strong> C#, Oracle, Visual Studio, ASP.NET, NUnit, NHibernate (ORM), Web Services, WSDL, TDD, PLSQL, Perforce.</p>

<ul>
  <li>
    <p>Working for the Northern Ireland Planning Service on a very large development project subcontracted through HP and BT. Technical design and implementation of web services, written in C# with Oracle as a back end.</p>
  </li>
  <li>
    <p>Interacting with end users and consultancies to architect appropriate solutions.</p>
  </li>
</ul>

<h4 id = ""developer-contract-11"" > Developer(contract) </ h4 >

< h2 id= ""cdc-respond"" > CDC Respond</h2>
<p><em>August 2008 - November 2008</em></p>

<p><strong>Skills:</strong> C# 3.0 .NET 3.5, SQL Server, Team Foundation Server, WPF, WCF, LINQ. TDD.</p>

<ul>
  <li>
    <p>Working from detailed specifications as part of a large development team. Writing web services code (WCF), and client side user interface code (WPF), to bring clients application up to date.</p>
  </li>
  <li>
    <p>Cleared defect backlog to hit zero bug bounce prior to releasing code to manufacture.</p>
  </li>
</ul>

<h4 id = ""developer-contract-12"" > Developer(contract) </ h4 >

< h2 id= ""pearson-oxford"" > Pearson(Oxford) </ h2 >
< p >< em > November 2007 - July 2008</em></p>

<p><strong>Skills:</strong> ASP.NET MVC, C#, Silverlight, XAML, SQL Server, VisualStudio.NET, TeamCity, REST, NUnit, TDD, watin, Selenium, Subversion, pair programming.</p>

<ul>
  <li>
    <p>Working in an agile team using XP, Scrum and continuous integration to develop a web site for Pearson to distribute disaggregated content.</p>
  </li>
  <li>
    <p>The web site was developed using the MVC pattern in C# with a RESTful architecture.</p>
  </li>
  <li>
    <p>Wrote front end in Silverlight that used the exposed API.</p>
  </li>
  <li>
    <p>Included the complete project life cycle. Analysis, modelling, and development.</p>
  </li>
  <li>
    <p>Responsible for sprint metrics such as code coverage, unit test completion and bug tracking.</p>
  </li>
</ul>

<h4 id = ""developer-contract-13"" > Developer(contract) </ h4 >

< h2 id= ""opp-oxford"" > OPP(Oxford) </ h2 >
< p >< em > August 2006 - October 2007</em></p>

<p><strong>Skills:</strong> ASP.NET 2.0 , C# 2.0, SQL Server 2005, VisualStudio.NET 2005, Windows Forms.</p>

<ul>
  <li>
    <p>Working from business requirements to design and develop an application to manage XML based documents.Created database design and overall architecture.</p>
  </li>
  <li>
    <p>Wrote server side code to process large xml documents and split these up into fragments to be stored in the database.</p>
  </li>
  <li>
    <p>Created a web service to retrieve and manage the xml fragments.</p>
  </li>
  <li>
    <p>Wrote a Windows Forms front end so business users can work with the xml fragments.Deployed using clickonce across the client’s intranet.</p>
  </li>
  <li>
    <p>Working in a very small team within an innovative web based company. The contract was renewed several times.</p>
  </li>
</ul>

<h4 id = ""developer-contract-14"" > Developer(contract) </ h4 >


< h2 id= ""rwe-npower"" > RWE nPower</h2>
<p><em>February 2006 - August 2006</em></p>

<ul>
  <li>
    <p><strong>Skills:</strong> ASP.NET 2.0 , C# 2.0, SQL Server, Oracle, VisualStudio.NET 2005, Nant, NUnit, FxCop, NCover, TDD.</p>
  </li>
  <li>
    <p>Working in Trading Decision Support, writing web services to deliver charting data from a variety of data sources.</p>
  </li>
  <li>
    <p>Scope included modelling and design of solutions.</p>
  </li>
  <li>
    <p>Writing code in C# to pull data from Sql Server, Oracle, Text Files and other Web Services.</p>
  </li>
  <li>
    <p>Writing complex aggregation routines to reshape data to dealer’s requirements.</p>
  </li>
  <li>
    <p>Providing a lead on agile development practices and creating project environments with .NET.</p>
  </li>
  <li>
    <p>Providing standards documents and documentation of recommended practices.</p>
  </li>
</ul>

<h2 id = ""ancient-experience"" > Ancient Experience</h2>

<h4 id = ""developer-contract-15"" > Developer(contract) </ h4 >


< h2 id= ""research-machines-abingdon"" > Research Machines (Abingdon)</h2>

<p><em>Dec 2005 – Jan 2006</em></p>

<p>ASP.NET, C#, VB.NET, SQL Server, SharePoint, Active Directory, SharePoint development, writing web parts and ASP.NET pages.</p>

<h4 id=""developer-contract-16""> Developer (contract)</h4>

<h2 id = ""blackwell-publishing-oxford"" > Blackwell Publishing (Oxford)</h2>

<p><em>February 2005 – November 2005</em></p>

<p>ASP.NET, C#, VB.NET, SQL Server, Web Services, VisualStudio.NET, .Net Framework, CSS, XML, XSLT, NUnit, Nant, FxCop, UML, BizTalk, Agile Software Development, Ajax, Developer, Web Front end to tracking system, Web services, stored procedures, TDD, OO modelling, Application Developer.</p>

<h4 id=""developer-contract-17""> Developer (contract)</h4>

<h2 id = ""elsevier-science-oxford"" > Elsevier Science (Oxford)</h2>

<p><em>June 2004 – January 2005</em></p>

<p>ASP.NET, C#, SQL Server, Web Services, Windows2003/XP, VisualStudio.NET, .Net Framework, SharePoint Portal Server, Web Parts, Technical Lead, Mentor, Load Testing, Web services.</p>

<h4 id=""developer-contract-18""> Developer (contract)</h4>

<h2 id = ""elsevier-science-oxford-1"" > Elsevier Science (Oxford)</h2>

<p><em>December 2001 – June 2004</em></p>

<p>ASP.NET, C#, XML, XSL, SQL Server, SOAP, Web Services, IIS, HTML, VisualStudio.NET, JavaScript, .Net Framework, Technical Lead.</p>

<h4 id=""developer-contract-19""> Developer (contract)</h4>

<h2 id = ""elsevier-science-oxford-2"" > Elsevier Science (Oxford)</h2>

<p><em>April 2001 – December 2001</em></p>

<p>ASP, Visual Basic 6, XML, XSL, SQL Server, SOAP, Web Services, NT, IIS HTML.</p>

<h4 id = ""developer-contract-20"" > Developer(contract) </ h4 >


< h2 id= ""achilles-information"" > Achilles Information</h2>

<p><em>November 2000 – March 2001</em></p>

<p>ASP, Visual Basic 6, XML, XSL, SQL Server, SOAP, Web services, NT, IIS, HTML, RDF.</p>

<h4 id = ""developer-contract-21"" > Developer(contract) </ h4 >


< h2 id= ""dell"" > DELL </ h2 >


< p >< em > AUGUST 2000 – NOVEMBER 2000</em></p>

<p>ASP, Visual Basic 6, XML, XSL, MTS, Oracle 8, NT, IIS, HTML, JavaScript, VBScript, PLSQL, Loadrunner.</p>

<h4 id = ""developer-contract-22"" > Developer(contract) </ h4 >


< h2 id= ""informed-people-oxford"" > Informed People (Oxford)</h2>

<p><em>February 2000 – August 2000</em></p>

<p>ASP, Visual Basic 6, XML, XSL, WML, SOAP, WAP, SQL Server 7, Oracle 8i, NT, HTML, VML, JavaScript, VBScript, PLSQL.</p>

<h4 id = ""developer-contract-23"" > Developer(contract) </ h4 >


< h2 id= ""bmw-gb"" > B.M.W. (GB) </ h2 >


< p >< em > July 1999 – February 2000</em></p>

<p>VB6, ASP, PL/SQL, MTS, ADO, XML, Windows NT, Oracle8, Access, COM, HTML.</p>

<h4 id = ""developer-contract-24"" > Developer(contract) </ h4 >


< h2 id= ""nortel-networks"" > Nortel Networks</h2>

<p><em>March 1999 – June 1999</em></p>

<p>VB6, VC++, HTML, ASP, Oracel8, PL/SQL, RDO, ADO, ActiveX, COM, Visual Modeller, FrontPage, Crystal Reports.</p>

<h4 id = ""developer-contract-25"" > Developer(contract) </ h4 >


< h2 id= ""capital-one-nottingham"" > Capital One (Nottingham)</h2>

<p><em>September 1998 – February 1999</em></p>

<p>VB6, Visual C++, PL/SQL, Oracle 8, ADO, ActiveX, COM/DCOM, OOP, Windows 95, Windows NT.</p>

<h4 id = ""developer-contract-26"" > Developer(contract) </ h4 >


< h2 id= ""ams-dusseldorf"" > A.M.S. (Dusseldorf) </ h2 >


< p >< em > July 1998 – August 1998</em></p>

<p>VB5, Access, SourceSafe, HTML, MS Agent, Win 95.</p>

<h4 id = ""developer-contract-27"" > Developer(contract) </ h4 >


< h2 id= ""powergen-coventry"" > PowerGen(Coventry) </ h2 >


< p >< em > April 1997 – June 1998</em></p>

<p>VB5, PLSQL, RDO, SourceSafe, Crystal reports.</p>

<h4 id = ""developer-contract-28"" > Developer(contract) </ h4 >


< h2 id= ""ws-atkins-newport"" > WS Atkins (Newport)</h2>

<p><em>January 1997 – March 1997</em></p>

<p>VB4, Oracle, SQL, ODBC API, RDO.</p>

<h4 id = ""developer-contract-29"" > Developer(contract) </ h4 >


< h2 id= ""windsor-life-telford"" > Windsor Life (Telford)</h2>

<p><em>October 1996 – December 1996</em></p>

<p>VB4, Oracle, SQL, Access, PVCS, Word.</p>

<h4 id = ""developer-contract-30"" > Developer(contract) </ h4 >


< h2 id= ""csc-cambridge"" > C.S.C(Cambridge) </ h2 >


< p >< em > February 1996 – September 1996</em></p>

<p>VB4, Access, OLE Automation, DDE, MS Project, OOP, SQL.</p>

<h4 id = ""developer-contract-31"" > Developer(contract) </ h4 >


< h2 id= ""british-gypsum"" > British Gypsum</h2>

<p><em>January 1996 – February 1996</em></p>

<p>VAX COBOL, POWERHOUSE.</p>

<h4 id = ""developer-contract-32"" > Developer(contract) </ h4 >


< h2 id= ""arjo-wiggins"" > Arjo Wiggins</h2>

<p><em>May 1995 – December 1995</em></p>

<p>VAX COBOL, DECFORMS, FMS, SQL, Access.</p>

<h4 id = ""developer-contract-33"" > Developer(contract) </ h4 >


< h2 id= ""anglia-water"" > Anglia Water</h2>

<p><em>January 1995 – April 1995</em></p>

<p>Visual Basic, VAX COBOL, SQLModule.</p>

<h4 id = ""developer-contract-34"" > Developer(contract) </ h4 >


< h2 id= ""at--t-istel"" > AT & amp; T ISTEL</h2>
    
<p><em>July 1994 – December 1994</em></p>

<p>DEC/VAX COBOL, POWERHOUSE.</p>

<h4 id = ""developer-contract-35"" > Developer(contract) </ h4 >
    

    < h2 id= ""national-power"" > National Power</h2>
    
<p><em>March 1993 – June 1994</em></p>

<p>VAX COBOL, VAX C, SLGMS.</p>

<h4 id = ""developer-contract-36"" > Developer(contract) </ h4 >
    

    < h2 id= ""kpmg"" > KPMG </ h2 >
    

    < p >< em > January 1993 – February 1993</em></p>

<p>VAX COBOL.</p>

<h4 id = ""developer-contract-37"" > Developer(contract) </ h4 >
    

    < h2 id= ""modo-group"" > MODO Group</h2>
    
<p><em>July 1992 – December 1992</em></p>

<p>VAX COBOL, POWERHOUSE.</p>

<h4 id = ""developer-contract-38"" > Developer(contract) </ h4 >
    

    < h2 id= ""at--t-istel-1"" > AT & amp; T ISTEL</h2>
         
<p><em>February 1991- June 1992</em></p>

<p>COBOL, POWERHOUSE.</p>

<h4 id = ""developer-permanent"" > Developer(permanent) </ h4 >
         

         < h2 id= ""sovico-france"" > SOVICO(France) </ h2 >
         

         < p >< em > August 1990 – January 1991</em></p>

<p>VAX COBOL, DCL.</p>

<h4 id = ""developer-contract-39"" > Developer(contract) </ h4 >
         

         < h2 id= ""dec-france"" > D.E.C. (France) </ h2 >
         

         < p >< em > December 1989 – July 1990</em></p>

<p>VAX PASCAL, VAX BASIC, DCL, SQL.</p>

<h4 id = ""developer-permanent-1"" > Developer(permanent) </ h4 >
         

         < h2 id= ""thomas-cook"" > Thomas Cook</h2>
         
<p><em>May 1987 – December 1989</em></p>

<p>VAX BASIC, PRO IV, COBOL, DCL.</p>

<h4 id = ""developer-permanent-2"" > Developer(permanent) </ h4 >
         

         < h2 id= ""workstations-ltd"" > Workstations Ltd.</h2>

<p><em>February 1985 – May 1987</em></p>

<p>DATAFLEX.</p>

<h4 id = ""developer-permanent-3"" > Developer(permanent) </ h4 >
         

         < h2 id= ""intec-ltd"" > INTEC Ltd.</h2>

<p><em>June 1984 – February 1985</em></p>

<p>BBC BASIC, 6502 Assembler.</p>

<h2 id = ""education"" > Education </ h2 >
         

         < h3 id= ""norwich-city-college"" > Norwich City College</h3>

<h2 id = ""bec-tec-hnd-computer-studies"" > BEC TEC HND Computer Studies</h2>

<p><em>september 1981 - June 1983</em></p>

<h3 id = ""king-edward-vii-upper-school"" > King Edward VII Upper School</h3>

<p>A Levels, O Levels</p>

<h2 id = ""skills"" > Skills </ h2 >
         

         < p > Programming Languages &amp; Tools</p>

<ul>
  <li><em>dotnet</em></li>
  <li><em>React</em></li>
  <li><em>Visual Studio</em></li>
  <li><em>Windows</em></li>
  <li><em>Angular JS</em></li>
  <li><em>Javascript</em></li>
  <li><em>SQL Server</em></li>
  <li><em>Atlassian</em></li>
  <li><em>Git</em></li>
  <li>
    <p><em>html5</em></p>
  </li>
  <li><a href = ""http://peter.withknown.com"" > Personal Blog</a></li>
  <li><a href = ""https://twitter.com/petermarshall"" > Twitter </ a ></ li >
  < li >< a href= ""https://linkedin.com/in/thebestdevyouwilleverfind"" > LinkedIn </ a ></ li >
  < li >< a href= ""https://stackoverflow.com/users/4692/peter-marshall"" > Stackoverflow </ a ></ li >
  < li >< a href= ""http://www.mycertprofile.com/Profile/9843288887"" > MS Certification</a></li>
</ul>

<h2 id = ""awards--certifications"" > Awards & amp; Certifications</h2>

<p><img src = ""https://petermarshall.github.io/blog/images/ms_professional_developer.png"" alt=""alt text"" title=""Microsoft Certified Professional Developer""></p>

<p><img src = ""https://petermarshall.github.io/blog/images/ms_certified_application_developer.png"" alt=""alt text"" title=""Microsoft Certified Application Developer""></p>

<p><img src = ""https://petermarshall.github.io/blog/images/ms_certifies_solution_developer.png"" alt=""alt text"" title=""Microsoft Certified Solution Developer""></p>

<p><img src = ""https://petermarshall.github.io/blog/images/ms_technology_specialist.png"" alt=""alt text"" title=""Microsoft Technology Specialist""></p>

<ul>
  <li><img src = ""./content/MCTS-NETFW2DistApps-logo-BW.png"" alt=""""></li>
  <li><img src = ""./content/MCTS-NETFW2WebApps-logo-BW.png"" alt=""""></li>
  <li><img src = ""./content/MCTS-NETFW2WinApps-logo-BW.png"" alt=""""></li>
  <li><img src = ""./content/MCPD-EnterpriseAppDev-logo-BW.png"" alt=""""></li>
  <li><img src = ""./content/MCAD-NET-logo-BW.png"" alt=""""></li>
  <li><img src = ""./content/MCSD1-VStudio6-logo-BW.png"" alt=""""></li>
</ul>


  </div>
</article>

        </div>
      </div>

      <div class=""wrapper-footer"">
        <div class=""container"">
          <footer class=""footer"">
            
<a href = ""mailto:marshall.peter@gmail.com"" >< i class=""svg-icon email""></i></a>


<a href = ""https://github.com/petermarshall"" >< i class=""svg-icon github""></i></a>

<a href = ""https://www.linkedin.com/in/thebestdevyouwilleverfind"" >< i class=""svg-icon linkedin""></i></a>

<a href = ""/blog/feed.xml"" >< i class=""svg-icon rss""></i></a>
<a href = ""https://www.twitter.com/petermarshall"" >< i class=""svg-icon twitter""></i></a>
<a href = ""http://stackoverflow.com/users/4692/peter-marshall"" >< i class=""svg-icon stackoverflow""></i></a>




          </footer>
        </div>
      </div>
    </div>

    
	<!-- Google Analytics -->
	<script>
		(function(i, s, o, g, r, a, m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function()
    {
        (i[r].q = i[r].q ||[]).push(arguments)},i[r].l=1* new Date(); a=s.createElement(o),
		m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a, m)
})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

ga('create', 'UA-153801665-1', 'auto');
ga('send', 'pageview', {
    'page': '/blog/cv/',
		  'title': 'CV'

        });

    </ script >

    < !--End Google Analytics -->


  

</body></html>";
        }
    }
}
