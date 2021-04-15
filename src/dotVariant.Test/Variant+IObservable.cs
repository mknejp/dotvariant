//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Test.Variants;
using Microsoft.Reactive.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using static Microsoft.Reactive.Testing.ReactiveTest;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class IObservable_Ex
        {
            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_1()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((int x) => x * 2);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, 2),
                    OnNext(400, 8));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_2()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((float x) => x * 2);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(200, 4f),
                    OnNext(500, 10f));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_3()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((string x) => x + " string");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(300, "3 string"),
                    OnNext(600, "6 string"));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_1()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((int x) => x * 2, -1);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, 2),
                    OnNext(200, -1),
                    OnNext(300, -1),
                    OnNext(400, 8),
                    OnNext(500, -1),
                    OnNext(600, -1));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_2()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((float x) => x * 2, -1f);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, -1f),
                    OnNext(200, 4f),
                    OnNext(300, -1f),
                    OnNext(400, -1f),
                    OnNext(500, 10f),
                    OnNext(600, -1f));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_3()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((string x) => x + " string", "x");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, "x"),
                    OnNext(200, "x"),
                    OnNext(300, "3 string"),
                    OnNext(400, "x"),
                    OnNext(500, "x"),
                    OnNext(600, "6 string"));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_1()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((int x) => x * 2, () => -1);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, 2),
                    OnNext(200, -1),
                    OnNext(300, -1),
                    OnNext(400, 8),
                    OnNext(500, -1),
                    OnNext(600, -1));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_2()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((float x) => x * 2, () => -1f);

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, -1f),
                    OnNext(200, 4f),
                    OnNext(300, -1f),
                    OnNext(400, -1f),
                    OnNext(500, 10f),
                    OnNext(600, -1f));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_3()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Match((string x) => x + " string", () => "x");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, "x"),
                    OnNext(200, "x"),
                    OnNext(300, "3 string"),
                    OnNext(400, "x"),
                    OnNext(500, "x"),
                    OnNext(600, "6 string"));
            }

            [Test]
            public static void Visit_transforms_each_element()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Class_int_float_string(1)),
                        OnNext(200, new Class_int_float_string(2f)),
                        OnNext(300, new Class_int_float_string("3")),
                        OnNext(400, new Class_int_float_string(4)),
                        OnNext(500, new Class_int_float_string(5f)),
                        OnNext(600, new Class_int_float_string("6")))
                    .Visit(
                        (int x) => $"int: {x}",
                        (float x) => $"float: {x}",
                        (string x) => $"string: {x}");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, "int: 1"),
                    OnNext(200, "float: 2"),
                    OnNext(300, "string: 3"),
                    OnNext(400, "int: 4"),
                    OnNext(500, "float: 5"),
                    OnNext(600, "string: 6"));
            }

            [Test]
            public static void Visit_throws_on_empty_element()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Struct_int_float_object(1)),
                        OnNext(200, new Struct_int_float_object(2f)),
                        OnNext(300, default(Struct_int_float_object)))
                    .Visit(
                        (int x) => $"int: {x}",
                        (float x) => $"float: {x}",
                        (Helper x) => $"Helper: {x}");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, "int: 1"),
                    OnNext(200, "float: 2"),
                    OnError<string>(300, ex => ex is InvalidOperationException));
            }

            [Test]
            public static void Visit_transforms_each_element_and_calls_empty_fallback()
            {
                var scheduler = new TestScheduler();
                var input =
                    scheduler.CreateHotObservable(
                        OnNext(100, new Struct_int_float_object(1)),
                        OnNext(200, new Struct_int_float_object(2f)),
                        OnNext(300, default(Struct_int_float_object)))
                    .Visit(
                        (int x) => $"int: {x}",
                        (float x) => $"float: {x}",
                        (Helper x) => $"Helper: {x}",
                        () => "empty");

                var output = scheduler.Start(() => input, 0, 0, 1000);
                output.Messages.AssertEqual(
                    OnNext(100, "int: 1"),
                    OnNext(200, "float: 2"),
                    OnNext(300, "empty"));
            }

            public static class VisitMany
            {
                [Test]
                public static void VisitMany_splits_values_into_sub_sequnces_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnNext(100, new Class_int_float_string(1)),
                            OnNext(200, new Class_int_float_string(2f)),
                            OnNext(300, new Class_int_float_string("3")),
                            OnNext(400, new Class_int_float_string(4)),
                            OnNext(500, new Class_int_float_string(5f)),
                            OnNext(600, new Class_int_float_string("6")));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s) =>
                                Observable
                                    .Merge(
                                        i.Do(observer1).Select(_ => new object()),
                                        f.Do(observer2).Select(_ => new object()),
                                        s.Do(observer3).Select(_ => new object()))),
                            0, 1, 1000);

                    observer1.Messages.AssertEqual(
                        OnNext(100, 1),
                        OnNext(400, 4));
                    observer2.Messages.AssertEqual(
                        OnNext(200, 2f),
                        OnNext(500, 5f));
                    observer3.Messages.AssertEqual(
                        OnNext(300, "3"),
                        OnNext(600, "6"));
                }

                [Test]
                public static void VisitMany_splits_values_into_sub_sequnces_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnNext(100, new Struct_int_float_string(1)),
                            OnNext(200, new Struct_int_float_string(2f)),
                            OnNext(300, new Struct_int_float_string("3")),
                            OnNext(400, new Struct_int_float_string()),
                            OnNext(500, new Struct_int_float_string(4)),
                            OnNext(600, new Struct_int_float_string(5f)),
                            OnNext(700, new Struct_int_float_string("6")),
                            OnNext(800, new Struct_int_float_string()));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();
                    var observer0 = scheduler.CreateObserver<Unit>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s, e) =>
                                Observable
                                    .Merge(
                                        i.Do(observer1).Select(_ => new object()),
                                        f.Do(observer2).Select(_ => new object()),
                                        s.Do(observer3).Select(_ => new object()),
                                        e.Do(observer0).Select(_ => new object()))),
                            0, 1, 1000);

                    observer1.Messages.AssertEqual(
                        OnNext(100, 1),
                        OnNext(500, 4));
                    observer2.Messages.AssertEqual(
                        OnNext(200, 2f),
                        OnNext(600, 5f));
                    observer3.Messages.AssertEqual(
                        OnNext(300, "3"),
                        OnNext(700, "6"));
                    observer0.Messages.AssertEqual(
                        OnNext(400, Unit.Default),
                        OnNext(800, Unit.Default));
                }

                [Test]
                public static void VisitMany_subscribes_to_combinator_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream = scheduler.CreateColdObservable<double>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s) => stream),
                            0, 100, 1000);

                    Assert.That(stream.Subscriptions, Has.Count.EqualTo(1));
                    Assert.That(stream.Subscriptions[0].Subscribe, Is.EqualTo(100));
                    Assert.That(stream.Subscriptions[0].Unsubscribe, Is.EqualTo(1000));
                }

                [Test]
                public static void VisitMany_subscribes_to_combinator_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream = scheduler.CreateColdObservable<double>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s, e) => stream),
                            0, 100, 1000);

                    Assert.That(stream.Subscriptions, Has.Count.EqualTo(1));
                    Assert.That(stream.Subscriptions[0].Subscribe, Is.EqualTo(100));
                    Assert.That(stream.Subscriptions[0].Unsubscribe, Is.EqualTo(1000));
                }

                [TestCaseSource(nameof(Forwarding_cases_1))]
                public static void VisitMany_forwards_values_from_combinator_1(Recorded<Notification<double>>[] values)
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream = scheduler.CreateHotObservable(values);

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s) => stream),
                            0, 1, 1000);

                    output.Messages.AssertEqual(values);
                }

                [TestCaseSource(nameof(Forwarding_cases_2))]
                public static void VisitMany_forwards_values_from_combinator_2(Recorded<Notification<double>>[] values)
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream = scheduler.CreateHotObservable(values);

                    var output =
                        scheduler.Start(
                            () => input.VisitMany((i, f, s, e) => stream),
                            0, 1, 1000);

                    output.Messages.AssertEqual(values);
                }

                private static readonly (string Name, Recorded<Notification<double>>[] Output)[] _forwarding_cases
                    = new[]
                    {
                        (
                            "OnNext",
                            new[]
                            {
                                OnNext(100, 1.0),
                                OnNext(200, 2.0),
                                OnNext(300, 3.0),
                                OnNext(400, 4.0),
                            }
                        ),
                        (
                            "OnError",
                            new[]
                            {
                                OnNext(100, 1.0),
                                OnNext(200, 2.0),
                                OnError<double>(300, new Exception()),
                            }
                        ),
                        (
                            "OnCompleted",
                            new[]
                            {
                                OnNext(100, 1.0),
                                OnNext(200, 2.0),
                                OnCompleted<double>(300),
                            }
                        ),
                    };

                private static IEnumerable<TestCaseData> Forwarding_cases_1()
                    => _forwarding_cases
                        .Select(test =>
                            new TestCaseData(test.Output)
                            .SetName($"{nameof(VisitMany_forwards_values_from_combinator_1)}({test.Name})"));

                private static IEnumerable<TestCaseData> Forwarding_cases_2()
                    => _forwarding_cases
                        .Select(test =>
                            new TestCaseData(test.Output)
                            .SetName($"{nameof(VisitMany_forwards_values_from_combinator_2)}({test.Name})"));
            }

            public static class VisitMany_with_sub_sequences
            {
                [Test]
                public static void VisitMany_splits_values_into_sub_sequnces_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnNext(100, new Class_int_float_string(1)),
                            OnNext(200, new Class_int_float_string(2f)),
                            OnNext(300, new Class_int_float_string("3")),
                            OnNext(400, new Class_int_float_string(4)),
                            OnNext(500, new Class_int_float_string(5f)),
                            OnNext(600, new Class_int_float_string("6")));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => xs.Do(observer1).Select(_ => new object()),
                                xs => xs.Do(observer2).Select(_ => new object()),
                                xs => xs.Do(observer3).Select(_ => new object())),
                            0, 0, 1000);

                    Assert.Multiple(() =>
                    {
                        observer1.Messages.AssertEqual(
                            OnNext(100, 1),
                            OnNext(400, 4));
                        observer2.Messages.AssertEqual(
                            OnNext(200, 2f),
                            OnNext(500, 5f));
                        observer3.Messages.AssertEqual(
                            OnNext(300, "3"),
                            OnNext(600, "6"));
                    });
                }

                [Test]
                public static void VisitMany_splits_values_into_sub_sequnces_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnNext(100, new Struct_int_float_string(1)),
                            OnNext(200, new Struct_int_float_string(2f)),
                            OnNext(300, new Struct_int_float_string("3")),
                            OnNext(400, new Struct_int_float_string()),
                            OnNext(500, new Struct_int_float_string(4)),
                            OnNext(600, new Struct_int_float_string(5f)),
                            OnNext(700, new Struct_int_float_string("6")),
                            OnNext(800, new Struct_int_float_string()));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();
                    var observer0 = scheduler.CreateObserver<Unit>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => xs.Do(observer1).Select(_ => new object()),
                                xs => xs.Do(observer2).Select(_ => new object()),
                                xs => xs.Do(observer3).Select(_ => new object()),
                                xs => xs.Do(observer0).Select(_ => new object())),
                            0, 0, 1000);

                    Assert.Multiple(() =>
                    {
                        observer1.Messages.AssertEqual(
                            OnNext(100, 1),
                            OnNext(500, 4));
                        observer2.Messages.AssertEqual(
                            OnNext(200, 2f),
                            OnNext(600, 5f));
                        observer3.Messages.AssertEqual(
                            OnNext(300, "3"),
                            OnNext(700, "6"));
                        observer0.Messages.AssertEqual(
                            OnNext(400, Unit.Default),
                            OnNext(800, Unit.Default));
                    });
                }

                [Test]
                public static void VisitMany_merges_values_from_sub_sequences_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var stream1 = scheduler.CreateHotObservable(
                        OnNext(100, 1.0),
                        OnNext(500, 5.0));
                    var stream2 = scheduler.CreateHotObservable(
                        OnNext(200, 2.0),
                        OnNext(400, 4.0));
                    var stream3 = scheduler.CreateHotObservable(
                        OnNext(300, 3.0),
                        OnNext(600, 6.0));

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3),
                            0, 1, 1000);

                    output.Messages.AssertEqual(
                        OnNext(100, 1.0),
                        OnNext(200, 2.0),
                        OnNext(300, 3.0),
                        OnNext(400, 4.0),
                        OnNext(500, 5.0),
                        OnNext(600, 6.0));
                }

                [Test]
                public static void VisitMany_merges_values_from_sub_sequences_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var stream1 = scheduler.CreateHotObservable(
                        OnNext(100, 1.0),
                        OnNext(500, 5.0));
                    var stream2 = scheduler.CreateHotObservable(
                        OnNext(200, 2.0),
                        OnNext(800, 8.0));
                    var stream3 = scheduler.CreateHotObservable(
                        OnNext(300, 3.0),
                        OnNext(700, 7.0));
                    var stream0 = scheduler.CreateHotObservable(
                        OnNext(400, 4.0),
                        OnNext(600, 6.0));

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3,
                                _ => stream0),
                            0, 1, 1000);

                    output.Messages.AssertEqual(
                        OnNext(100, 1.0),
                        OnNext(200, 2.0),
                        OnNext(300, 3.0),
                        OnNext(400, 4.0),
                        OnNext(500, 5.0),
                        OnNext(600, 6.0),
                        OnNext(700, 7.0),
                        OnNext(800, 8.0));
                }

                [Test]
                public static void VisitMany_immediately_subscribes_to_all_sub_sequences_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream1 = scheduler.CreateColdObservable<object>();
                    var stream2 = scheduler.CreateColdObservable<object>();
                    var stream3 = scheduler.CreateColdObservable<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3),
                            0, 100, 1000);

                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions, Has.Count.EqualTo(1));
                        Assert.That(stream2.Subscriptions, Has.Count.EqualTo(1));
                        Assert.That(stream3.Subscriptions, Has.Count.EqualTo(1));
                    });
                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions[0].Subscribe, Is.EqualTo(100));
                        Assert.That(stream2.Subscriptions[0].Subscribe, Is.EqualTo(100));
                        Assert.That(stream3.Subscriptions[0].Subscribe, Is.EqualTo(100));
                    });
                }

                [Test]
                public static void VisitMany_immediately_subscribes_to_all_sub_sequences_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateColdObservable<Class_int_float_string>();

                    var stream0 = scheduler.CreateColdObservable<object>();
                    var stream1 = scheduler.CreateColdObservable<object>();
                    var stream2 = scheduler.CreateColdObservable<object>();
                    var stream3 = scheduler.CreateColdObservable<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3,
                                _ => stream0),
                            0, 100, 1000);

                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions, Has.Count.EqualTo(1));
                        Assert.That(stream2.Subscriptions, Has.Count.EqualTo(1));
                        Assert.That(stream3.Subscriptions, Has.Count.EqualTo(1));
                        Assert.That(stream0.Subscriptions, Has.Count.EqualTo(1));
                    });
                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions[0].Subscribe, Is.EqualTo(100));
                        Assert.That(stream2.Subscriptions[0].Subscribe, Is.EqualTo(100));
                        Assert.That(stream3.Subscriptions[0].Subscribe, Is.EqualTo(100));
                        Assert.That(stream0.Subscriptions[0].Subscribe, Is.EqualTo(100));
                    });
                }

                [Test]
                public static void VisitMany_forwards_unsubscribe_to_sub_sequences_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var stream1 = scheduler.CreateColdObservable<object>();
                    var stream2 = scheduler.CreateColdObservable<object>();
                    var stream3 = scheduler.CreateColdObservable<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3),
                            0, 100, 500);

                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                        Assert.That(stream2.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                        Assert.That(stream3.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                    });
                }

                [Test]
                public static void VisitMany_forwards_unsubscribe_to_sub_sequences_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var stream0 = scheduler.CreateColdObservable<object>();
                    var stream1 = scheduler.CreateColdObservable<object>();
                    var stream2 = scheduler.CreateColdObservable<object>();
                    var stream3 = scheduler.CreateColdObservable<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => stream1,
                                _ => stream2,
                                _ => stream3,
                                _ => stream0),
                            0, 100, 500);

                    Assert.Multiple(() =>
                    {
                        Assert.That(stream1.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                        Assert.That(stream2.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                        Assert.That(stream3.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                        Assert.That(stream0.Subscriptions[0].Unsubscribe, Is.EqualTo(500));
                    });
                }

                [Test]
                public static void VisitMany_forwards_OnComplete_to_sub_sequences_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnCompleted<Class_int_float_string>(500));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => xs.Do(observer1).Select(_ => new object()),
                                xs => xs.Do(observer2).Select(_ => new object()),
                                xs => xs.Do(observer3).Select(_ => new object())),
                            0, 100, 1000);

                    observer1.Messages.AssertEqual(OnCompleted<int>(500));
                    observer2.Messages.AssertEqual(OnCompleted<float>(500));
                    observer3.Messages.AssertEqual(OnCompleted<string>(500));
                }

                [Test]
                public static void VisitMany_forwards_OnComplete_to_sub_sequences_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable(
                            OnCompleted<Class_int_float_string>(500));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();
                    var observer0 = scheduler.CreateObserver<Unit>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => xs.Do(observer1).Select(_ => new object()),
                                xs => xs.Do(observer2).Select(_ => new object()),
                                xs => xs.Do(observer3).Select(_ => new object()),
                                xs => xs.Do(observer0).Select(_ => new object())),
                            0, 100, 1000);

                    observer1.Messages.AssertEqual(OnCompleted<int>(500));
                    observer2.Messages.AssertEqual(OnCompleted<float>(500));
                    observer3.Messages.AssertEqual(OnCompleted<string>(500));
                    observer0.Messages.AssertEqual(OnCompleted<Unit>(500));
                }

                [Test]
                public static void VisitMany_forwards_OnError_to_sub_sequences_1()
                {
                    var scheduler = new TestScheduler();
                    var error = new Exception();
                    var input =
                        scheduler.CreateHotObservable(
                            OnError<Class_int_float_string>(500, error));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => { _ = xs.Subscribe(observer1); return Observable.Never<object>(); },
                                xs => { _ = xs.Subscribe(observer2); return Observable.Never<object>(); },
                                xs => { _ = xs.Subscribe(observer3); return Observable.Never<object>(); }),
                            0, 100, 1000);

                    observer1.Messages.AssertEqual(OnError<int>(500, ex => ReferenceEquals(ex, error)));
                    observer2.Messages.AssertEqual(OnError<float>(500, ex => ReferenceEquals(ex, error)));
                    observer3.Messages.AssertEqual(OnError<string>(500, ex => ReferenceEquals(ex, error)));
                }

                [Test]
                public static void VisitMany_forwards_OnError_to_sub_sequences_2()
                {
                    var scheduler = new TestScheduler();
                    var error = new Exception();
                    var input =
                        scheduler.CreateHotObservable(
                            OnError<Class_int_float_string>(500, error));

                    var observer1 = scheduler.CreateObserver<int>();
                    var observer2 = scheduler.CreateObserver<float>();
                    var observer3 = scheduler.CreateObserver<string>();
                    var observer0 = scheduler.CreateObserver<Unit>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                xs => { _ = xs.Subscribe(observer1); return Observable.Never<object>(); },
                                xs => { _ = xs.Subscribe(observer2); return Observable.Never<object>(); },
                                xs => { _ = xs.Subscribe(observer3); return Observable.Never<object>(); },
                                xs => { _ = xs.Subscribe(observer0); return Observable.Never<object>(); }),
                            0, 100, 1000);

                    observer1.Messages.AssertEqual(OnError<int>(500, ex => ReferenceEquals(ex, error)));
                    observer2.Messages.AssertEqual(OnError<float>(500, ex => ReferenceEquals(ex, error)));
                    observer3.Messages.AssertEqual(OnError<string>(500, ex => ReferenceEquals(ex, error)));
                    observer0.Messages.AssertEqual(OnError<Unit>(500, ex => ReferenceEquals(ex, error)));
                }

                [Test]
                public static void VisitMany_terminates_when_any_sub_sequence_terminates_with_OnError_1([Values(1, 2, 3)] int sub)
                {
                    var scheduler = new TestScheduler();
                    var error = new Exception();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    IObservable<object> MakeSubSequence(int i)
                        => i == sub ? scheduler.CreateHotObservable(OnError<object>(500, error)) : Observable.Never<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => MakeSubSequence(1),
                                _ => MakeSubSequence(2),
                                _ => MakeSubSequence(3)),
                            0, 100, 1000);

                    output.Messages.AssertEqual(OnError<object>(500, ex => ReferenceEquals(ex, error)));
                }

                [Test]
                public static void VisitMany_terminates_when_any_sub_sequence_terminates_with_OnError_2([Values(1, 2, 3, 4)] int sub)
                {
                    var scheduler = new TestScheduler();
                    var error = new Exception();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    IObservable<object> MakeSubSequence(int i)
                        => i == sub ? scheduler.CreateHotObservable(OnError<object>(500, error)) : Observable.Never<object>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => MakeSubSequence(1),
                                _ => MakeSubSequence(2),
                                _ => MakeSubSequence(3),
                                _ => MakeSubSequence(4)),
                            0, 100, 1000);

                    output.Messages.AssertEqual(OnError<object>(500, ex => ReferenceEquals(ex, error)));
                }

                [Test]
                public static void VisitMany_terminates_when_all_sub_sequences_terminate_with_OnCompleted_1()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(300)),
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(400)),
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(500))),
                            0, 100, 1000);

                    output.Messages.AssertEqual(OnCompleted<object>(500));
                }

                [Test]
                public static void VisitMany_terminates_when_all_sub_sequences_terminate_with_OnCompleted_2()
                {
                    var scheduler = new TestScheduler();
                    var input =
                        scheduler.CreateHotObservable<Class_int_float_string>();

                    var output =
                        scheduler.Start(
                            () => input.VisitMany(
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(300)),
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(400)),
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(500)),
                                _ => scheduler.CreateHotObservable(OnCompleted<object>(600))),
                            0, 100, 1000);

                    output.Messages.AssertEqual(OnCompleted<object>(600));
                }
            }
        }
    }
}
