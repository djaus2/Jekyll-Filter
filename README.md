# Jekyll Filter
A Windows Forms app to get web pages and Word documents into a Jekyll Blog site and Markdown. 

[![Build Status](https://dev.azure.com/SportronicsAu/JekyllFilterClickOnce/_apis/build/status/djaus2.Jekyll-Filter?branchName=master)](https://dev.azure.com/SportronicsAu/JekyllFilterClickOnce/_build/latest?definitionId=5&branchName=master)

Needs [Pandoc](http://pandoc.org) to be installed.

Also, uses [YamlDotNet](https://www.nuget.org/packages/YamlDotNet)

This project was started as a component of the repository https://github.com/djaus2/djaus2.github.io.

That project is a Jekyll Blog site but has the first version of this in a subfolder (Filter). The above site was then migrated to Azure Devops where the FilterWf project was extended extensively, and this is the reseult.

The new (DevOps and Azure hosted) site is now at https://davidjones.sportronics.com.au

## ClickOnce 
Install directly from [here](https://appz.sportronics.com.au) *Hosted on an Azure Blob Storage-Static Web site*

## With this app you can:
- Convert a Word document to MD
- Convert an Html document to MD
- Download a web page and convert it to MD
- Filter out some of the crud from converted web pages
- Preview an MD page
- Place converted pages directly into your Jekyll blog site

***All of this is done in-app!***

