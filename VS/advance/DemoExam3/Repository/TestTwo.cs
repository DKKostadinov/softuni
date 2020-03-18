using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Repository;

public class TestTwo
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    // Test if all the properties in class Person are defined.
    [Test]
    public void ZeroTestTwo()
    {
        var person = GetType("Person");

        //Properties Part
        Dictionary<string, string> expectedProperties = new Dictionary<string, string>()
            {
                { "Name", "String"},
                { "Age", "Int32"},
                { "Birthdate", "DateTime"},
            };

        PropertyInfo[] properties = person
            .GetProperties();

        Assert.That(properties.Length == 3);

        foreach (var property in properties)
        {
            if (expectedProperties.ContainsKey(property.Name) && expectedProperties[property.Name] == property.PropertyType.Name)
            {
                expectedProperties.Remove(property.Name);
            }
        }

        Assert.That(expectedProperties.Count == 0);

        // Constructor Part
        ConstructorInfo constructor = person
            .GetConstructors()
            .FirstOrDefault(x => x.GetParameters().Length == 3);

        var expectedParametersTypes = new Dictionary<string, int>()
            {
                {"String", 1 },
                {"Int32", 1 },
                {"DateTime", 1 },
            };

        var actualParametersTypes = new Dictionary<string, int>();

        foreach (var parameter in constructor.GetParameters())
        {
            string parameterTypeName = parameter.ParameterType.Name;

            if (!actualParametersTypes.ContainsKey(parameterTypeName))
            {
                actualParametersTypes[parameterTypeName] = 0;
            }

            actualParametersTypes[parameterTypeName]++;
        }

        foreach (var kvp in actualParametersTypes)
        {
            string type = kvp.Key;
            int count = kvp.Value;

            if (expectedParametersTypes.ContainsKey(type) && expectedParametersTypes[type] == count)
            {
                expectedParametersTypes.Remove(type);
            }
        }

        Assert.That(expectedParametersTypes.Count == 0);

    }

    private static object CreateObjectInstance(Type type, params object[] parameters)
    {
        try
        {
            var obj = Activator.CreateInstance(type, parameters);
            return obj;
        }
        catch (TargetInvocationException e)
        {
            throw e.InnerException;
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}