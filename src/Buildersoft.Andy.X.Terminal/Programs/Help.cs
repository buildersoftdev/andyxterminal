﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Buildersoft.Andy.X.Terminal.Programs
{
    public static class Help
    {
        public static void ShowHelp()
        {
            Console.Clear();
            Console.WriteLine("Andy Terminal > Help");
            Console.WriteLine("'clear' : Clean the screen");
            Console.WriteLine();

            Console.WriteLine("'node' : node appliation, functions");
            Console.WriteLine("     ->  'node list' -> show all andy x nodes");
            Console.WriteLine("     ->  'node add ' -> add andy x nodes");
            Console.WriteLine("     ->  'node edit ' -> edit andy x nodes");
            Console.WriteLine("     ->  'node delete ' -> delete andy x nodes");
            Console.WriteLine("     ->  'node detail ' -> read andy x nodes details");
            Console.WriteLine("     ->  'node select {index} ' -> select andy x nodes");

            Console.WriteLine("'tenant' : tenant appliation, functions");
            Console.WriteLine("     ->  'tenant add {tenantName}' -> register a tenant");
            Console.WriteLine("     ->  'tenant view {tenantName}' -> get tenant data");
            Console.WriteLine();

            Console.WriteLine("'product' : product appliation, functions");
            Console.WriteLine("     ->  'product add {tenantName}/{productName}' -> register a product");
            Console.WriteLine("     ->  'product view {tenantName}/{productName}' -> get product data");
            Console.WriteLine();

            Console.WriteLine("'component' : component appliation, functions");
            Console.WriteLine("     ->  'component add {tenantName}/{productName}/{componentName}' -> register a component");
            Console.WriteLine("     ->  'component view {tenantName}/{productName}/{componentName}' -> get component data");
            Console.WriteLine();

            Console.WriteLine("'book' : book appliation, functions");
            Console.WriteLine("     ->  'book add {tenantName}/{productName}/{componentName}/{book}' -> register a book");
            Console.WriteLine("     ->  'book view {tenantName}/{productName}/{componentName}/{book}' -> get book data");
            Console.WriteLine();

            Console.WriteLine("'schema' : schema feature, book appliation, functions");
            Console.WriteLine("     ->  'schema view {tenantName}/{productName}/{componentName}/{book}' -> get schema data");
            Console.WriteLine();

            Console.WriteLine("'reader' : reader appliation, functions");
            Console.WriteLine("     ->  'reader listen andyx://{tenantName}/{productName}/{componentName}/{book}/{readerName}/{readerType}'");
            Console.WriteLine("     ->  'readerTypes can be 'Exclusive', 'Failover', 'Shared'");
            Console.WriteLine("     ->  'reader uses WebSocket to communiate with Andy X");
            Console.WriteLine();

            Console.WriteLine("'about' : about Buildersoft Andy X Terminal");
        }
        public static void ShowAbout()
        {
            Console.Clear();
            Console.WriteLine("Buildersoft Andy X Terminal");
            Console.WriteLine("January Feature Pack Update");
            Console.WriteLine($"Version {Assembly.GetExecutingAssembly().GetName().Version}");
            Console.WriteLine($"Build {Assembly.GetExecutingAssembly().GetName().Version.Build}");
            Console.WriteLine("Andy X is an open-source distributed streaming platform designed to deliver the best performance possible for high-performance data pipelines, streaming analytics, streaming between microservices and data integrations. Andy X Terminal will help to control resources inside Andy X.");
            Console.WriteLine("\n(c) 2021 Buildersoft. All rights reserved.");
            Console.WriteLine("");
        }
    }

}
