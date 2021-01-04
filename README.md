# Countwiki

<br>
<h3>Created for QUAL ID.</h3>
<br>
I have done this in dot net 5. It's a standard ASP.NET MVC web site. There is a service called <emphasis>WordCounter</emphasis> that counts the words in an HTML string.
It has a dependency on the HTML Agility Pack. I considered using a DOM Document, but as that would depend on parsed XML was not sure it would work. So I used the HTML Agility Pack Library to parse the html.
There are tests for the <emphasis>Count</emphasis> method of this service. The service is injected into the controller.

The front end is a very simple, and is routed through the home controller. The controller calls wikipedia to get the html for the URL. I tested it on a page, I am guessing I would have to use URL Encoding for a more complex url, but I have not gone that far.  I tested it on [Oxford - Wikipedia](https://en.wikipedia.org/wiki/Oxford) and it worked.

<br>
<br> 
