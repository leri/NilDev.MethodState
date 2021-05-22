using System;
using System.IO;
using System.Text;

namespace MethodState.AutoGenerator
{
    class Program
    {
        private static bool NotElevenTwelveOrThirteen(byte i)
        {
            return i != 11 && i != 12 && i != 13;
        }

        private static string GetOrdinalNumber(byte i)
        {
            int lastDigit = NotElevenTwelveOrThirteen(i) ? i % 10 : -1;

            switch (lastDigit)
            {
                case 1:
                    return $"{i}st";
                case 2:
                    return $"{i}nd";
                case 3:
                    return $"{i}rd";
                default:
                    return $"{i}th";
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number of generated generic MethodState files: ");
                string input = Console.ReadLine();

                if (!byte.TryParse(input, out byte maxGenerics) || maxGenerics == byte.MinValue || maxGenerics == byte.MaxValue)
                {
                    Console.WriteLine("Invalid max number of generics");
                    continue;
                }

                for (byte i = 0; i < maxGenerics; i++)
                {
                    byte currentCountOfGenerics = (byte)(i + 1);
                    string fileName = $@"..\..\..\..\NilDev.MethodState\MethodState{currentCountOfGenerics}.generated.cs";

                    if (File.Exists(fileName))
                    {
                        try
                        {
                            Console.WriteLine($@"File ""{fileName}"" already exists. Deleting it...");
                            File.Delete(fileName);
                            Console.WriteLine($@"File ""{fileName}"" deleted.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Could not delete the file:");
                            Console.WriteLine(ex);
                            continue;
                        }
                    }

                    char? argumentSeparator = null;
                    string stateSwitchDefinitionSB = @"
            switch (_selectedTypeIndex)
            {";

                    var genericDefinitionSB = new StringBuilder();
                    var actionDefinitionSB = new StringBuilder();
                    var voidObserveCasesSB = new StringBuilder(stateSwitchDefinitionSB);
                    var resultObserverCaseSB = new StringBuilder(stateSwitchDefinitionSB);
                    var genericsDocumentationSB = new StringBuilder();
                    var synchronousObserverDocumentationSB = new StringBuilder();
                    var asynchronousObserverDocumentationSB = new StringBuilder();
                    var asyncObserversDefinitionSB = new StringBuilder();
                    var transformerObserversDefinitionSB = new StringBuilder();
                    var asyncTransformerObserversDefinitionSB = new StringBuilder();
                    var observMethodCallSB = new StringBuilder(@"
            return Observe(");
                    var ctorSB = new StringBuilder();
                    var implicitCastSB = new StringBuilder();

                    genericDefinitionSB.Append('<');
                    actionDefinitionSB.Append('(');
                    asyncObserversDefinitionSB.Append('(');
                    transformerObserversDefinitionSB.Append('(');
                    asyncTransformerObserversDefinitionSB.Append('(');

                    for (byte j = 0; j < currentCountOfGenerics; j++)
                    {
                        if (!(argumentSeparator is null))
                        {
                            genericDefinitionSB.Append(argumentSeparator);
                            genericDefinitionSB.Append(' ');
                        }

                        byte currentGenericNumber = (byte)(j + 1);
                        string genericType = $"T{currentGenericNumber}";

                        genericDefinitionSB.Append(genericType);
                        argumentSeparator = ',';
                    }

                    genericDefinitionSB.Append('>');
                    argumentSeparator = null;

                    for (byte j = 0; j < currentCountOfGenerics; j++)
                    {
                        byte currentGenericNumber = (byte)(j + 1);
                        string ordinalGenericNumber = GetOrdinalNumber(currentGenericNumber);

                        string genericType = $"T{currentGenericNumber}";
                        string stateName = "_state";
                        string currentStateName = $"state{currentGenericNumber}";
                        string observerName = $"observer{currentGenericNumber}";
                        string funcTypeDefinition = $"Func<{genericType}, ";

                        genericsDocumentationSB.Append(@"
    /// <typeparam name=""");
                        genericsDocumentationSB.Append(genericType);
                        genericsDocumentationSB.Append(@""">Type of a ");
                        genericsDocumentationSB.Append(ordinalGenericNumber);
                        genericsDocumentationSB.Append(" possible state.</typeparam>");

                        synchronousObserverDocumentationSB.Append(@"
        /// <param name=""");
                        synchronousObserverDocumentationSB.Append(observerName);
                        synchronousObserverDocumentationSB.Append(@""">Observer for the ");
                        synchronousObserverDocumentationSB.Append(ordinalGenericNumber);
                        synchronousObserverDocumentationSB.Append(" state.</param>");

                        asynchronousObserverDocumentationSB.Append(@"
        /// <param name=""");
                        asynchronousObserverDocumentationSB.Append(observerName);
                        asynchronousObserverDocumentationSB.Append(@""">Asynchronous observer for the ");
                        asynchronousObserverDocumentationSB.Append(ordinalGenericNumber);
                        asynchronousObserverDocumentationSB.Append(" state.</param>");

                        var caseSB = new StringBuilder(@"
                case ");
                        caseSB.Append(currentGenericNumber);
                        caseSB.Append(':');
                        var stateCastSB = new StringBuilder(@"
                    var ");
                        stateCastSB.Append(currentStateName);
                        stateCastSB.Append(" = (");
                        stateCastSB.Append(genericType);
                        stateCastSB.Append(')');
                        stateCastSB.Append(stateName);
                        stateCastSB.Append(@";
                    ");
                        var observerCallSB = new StringBuilder(observerName);
                        observerCallSB.Append('(');
                        observerCallSB.Append(currentStateName);
                        observerCallSB.Append(')');
                        observerCallSB.Append(';');

                        voidObserveCasesSB.Append(caseSB);
                        voidObserveCasesSB.Append(stateCastSB);
                        voidObserveCasesSB.Append(observerCallSB);
                        voidObserveCasesSB.Append(@"
                    break;");

                        resultObserverCaseSB.Append(caseSB);
                        resultObserverCaseSB.Append(stateCastSB);
                        resultObserverCaseSB.Append("return ");
                        resultObserverCaseSB.Append(observerCallSB);

                        if (!(argumentSeparator is null))
                        {
                            actionDefinitionSB.Append(argumentSeparator);
                            actionDefinitionSB.Append(' ');

                            asyncObserversDefinitionSB.Append(argumentSeparator);
                            asyncObserversDefinitionSB.Append(' ');

                            transformerObserversDefinitionSB.Append(argumentSeparator);
                            transformerObserversDefinitionSB.Append(' ');

                            asyncTransformerObserversDefinitionSB.Append(argumentSeparator);
                            asyncTransformerObserversDefinitionSB.Append(' ');

                            observMethodCallSB.Append(argumentSeparator);
                            observMethodCallSB.Append(' ');
                        }

                        actionDefinitionSB.Append("Action<");
                        actionDefinitionSB.Append(genericType);
                        actionDefinitionSB.Append('>');
                        actionDefinitionSB.Append(' ');
                        actionDefinitionSB.Append(observerName);

                        asyncObserversDefinitionSB.Append(funcTypeDefinition);
                        asyncObserversDefinitionSB.Append("Task>");
                        asyncObserversDefinitionSB.Append(' ');
                        asyncObserversDefinitionSB.Append(observerName);

                        transformerObserversDefinitionSB.Append(funcTypeDefinition);
                        transformerObserversDefinitionSB.Append("TResult>");
                        transformerObserversDefinitionSB.Append(' ');
                        transformerObserversDefinitionSB.Append(observerName);

                        asyncTransformerObserversDefinitionSB.Append(funcTypeDefinition);
                        asyncTransformerObserversDefinitionSB.Append("Task<TResult>>");
                        asyncTransformerObserversDefinitionSB.Append(' ');
                        asyncTransformerObserversDefinitionSB.Append(observerName);

                        observMethodCallSB.Append(observerName);

                        ctorSB.Append(@"

        /// <summary>
        /// Constructs the ");
                        ctorSB.Append(ordinalGenericNumber);
                        ctorSB.Append(@" state.
        /// </summary>
        /// <param name=""state"">Current state.</param>
        private MethodState(");
                        ctorSB.Append(genericType);
                        ctorSB.Append(@" state)
        {
            _state = state;
            _selectedTypeIndex = ");
                        ctorSB.Append(currentGenericNumber);
                        ctorSB.Append(@";
        }");

                        implicitCastSB.Append(@"

        /// <summary>
        /// Implicit cast for the ");
                        implicitCastSB.Append(ordinalGenericNumber);
                        implicitCastSB.Append(@" state.
        /// </summary>
        /// <param name=""state"">Current state.</param>
        public static implicit operator MethodState");
                        implicitCastSB.Append(genericDefinitionSB);
                        implicitCastSB.Append("(");
                        implicitCastSB.Append(genericType);
                        implicitCastSB.Append(@" state)
        {
            if (state is null)
            {
                return new MethodState");
                        implicitCastSB.Append(genericDefinitionSB);
                        implicitCastSB.Append(@"();
            }

            return new MethodState");
                        implicitCastSB.Append(genericDefinitionSB);
                        implicitCastSB.Append(@"(state);
        }");

                        argumentSeparator = ',';
                    }

                    actionDefinitionSB.Append(", Action nullObserver)");
                    asyncObserversDefinitionSB.Append(", Func<Task> nullObserver)");
                    transformerObserversDefinitionSB.Append(", Func<TResult> nullObserver)");
                    asyncTransformerObserversDefinitionSB.Append(", Func<Task<TResult>> nullObserver)");
                    observMethodCallSB.Append(", nullObserver);");
                    voidObserveCasesSB.Append(@"
                case 0:
                    nullObserver();
                    break;
                default:
                    throw new InvalidOperationException(""Cannot determine the method state."");
            }");

                    resultObserverCaseSB.Append(@"
                case 0:
                    return nullObserver();
                default:
                    throw new InvalidOperationException(""Cannot determine the method state."");
            }");

                    StringBuilder sb = new StringBuilder(@"using System;
using System.Threading.Tasks;

namespace NilDev.MethodState
{
    /// <summary>
    /// Describes the possible states which can be returned by a method and gives the possibility to observe it when required.
    /// </summary>");
                    sb.Append(genericsDocumentationSB);
                    sb.Append(@"
    public struct MethodState");
                    sb.Append(genericDefinitionSB);
                    sb.Append(@"
    {
        private readonly object _state;
        private readonly byte _selectedTypeIndex;");
                    sb.AppendLine();
                    sb.Append(@"
        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer.
        /// </summary>");
                    sb.Append(synchronousObserverDocumentationSB);
                    sb.Append(@"
        /// <param name=""nullObserver"">Observer when the current state is null</param>
        public void Observe");
                    sb.Append(actionDefinitionSB);
                    sb.AppendLine(@"
        {");

                    sb.Append(voidObserveCasesSB);
                    sb.Append(@"
        }

        /// <summary>
        /// This method lets the caller observe the current state asynchronously by calling respective state observer.
        /// </summary>");
                    sb.Append(asynchronousObserverDocumentationSB);
                    sb.Append(@"
        /// <param name=""nullObserver"">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task ObserveAsync");
                    sb.Append(asyncObserversDefinitionSB);
                    sb.Append(@"
        {");
                    sb.Append(observMethodCallSB);
                    sb.Append(@"
        }

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer and returns an observation result.
        /// </summary>
        /// <typeparam name=""TResult"">Type of observation result.</typeparam>");
                    sb.Append(synchronousObserverDocumentationSB);
                    sb.Append(@"
        /// <param name=""nullObserver"">Observer when the current state is null</param>
        /// <returns>Observation result.</returns>
        public TResult Observe<TResult>");
                    sb.Append(transformerObserversDefinitionSB);
                    sb.Append(@"
        {");
                    sb.Append(resultObserverCaseSB);
                    sb.Append(@"
        }

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer and returns an observation result asynchronously.
        /// </summary>
        /// <typeparam name=""TResult"">Type of observation result.</typeparam>");
                    sb.Append(asynchronousObserverDocumentationSB);
                    sb.Append(@"
        /// <param name=""nullObserver"">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task<TResult> ObserveAsync<TResult>");
                    sb.Append(asyncTransformerObserversDefinitionSB);
                    sb.Append(@"
        {");
                    sb.Append(observMethodCallSB);
                    sb.Append(@"
        }");
                    sb.Append(ctorSB);
                    sb.Append(implicitCastSB);

                    sb.Append(@"
    }
}");

                    File.WriteAllText(fileName, sb.ToString());
                }

                break;
            }
        }
    }
}
