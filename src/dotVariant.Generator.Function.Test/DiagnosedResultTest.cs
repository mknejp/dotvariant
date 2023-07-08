//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator.Function.Te;

public sealed class DiagnosedResultTest
{
    [Test]
    public void DefaultHasError()
    {
        DiagnosedResult<int> res = default;
        Assert.That(res.HasErrors);
    }

    public static IEnumerable<object> ValueEmptyDiagnosticsNotHasErrorsSource => new object[] { 23, };

    [Test, TestCaseSource(nameof(ValueEmptyDiagnosticsNotHasErrorsSource))]
    public void ValueEmptyDiagnosticsNotHasErrors(object expectedValue)
    {
        DiagnosedResult<object> res = new(expectedValue);
        Assert.That(!res.HasErrors);
        Assert.That(res.TryGetValue(out var value));
        Assert.That(value, Is.EqualTo(expectedValue));
    }


    private static Diagnostic CreateDummyDiagnostic(DiagnosticSeverity severity)
    {
        var severityName = severity.ToString();
        return Diagnostic.Create(
            new DiagnosticDescriptor("0", severityName, severityName, severityName, severity, true),
            Location.Create("Test", new TextSpan(0, 1),
                new LinePositionSpan(new LinePosition(0, 0), new LinePosition(0, 1))));
    }

    public static IEnumerable<Diagnostic> HasErrorDiagnosticsHasErrorsSource =>
        Enum.GetValues<DiagnosticSeverity>().Select(CreateDummyDiagnostic).ToArray();

    [Test, TestCaseSource(nameof(HasErrorDiagnosticsHasErrorsSource))]
    public void ValueHasErrorDiagnosticsHasErrors(Diagnostic diagnostic)
    {
        var res = default(DiagnosedResult<object>).WithDiagnostics(ImmutableArray.Create(diagnostic));
        var isSeverityError = diagnostic.Severity >= DiagnosticSeverity.Error;
        Assert.That(res.HasErrors, Is.EqualTo(isSeverityError));
        Assert.That(res.TryGetValue(out _), Is.EqualTo(!isSeverityError));
    }
}
