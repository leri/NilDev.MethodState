using System;
using System.Threading.Tasks;

namespace NilDev.MethodState
{
    /// <summary>
    /// Describes the possible states which can be returned by a method and gives the possibility to observe it when required.
    /// </summary>
    /// <typeparam name="T1">Type of a 1st possible state.</typeparam>
    /// <typeparam name="T2">Type of a 2nd possible state.</typeparam>
    /// <typeparam name="T3">Type of a 3rd possible state.</typeparam>
    /// <typeparam name="T4">Type of a 4th possible state.</typeparam>
    /// <typeparam name="T5">Type of a 5th possible state.</typeparam>
    /// <typeparam name="T6">Type of a 6th possible state.</typeparam>
    /// <typeparam name="T7">Type of a 7th possible state.</typeparam>
    /// <typeparam name="T8">Type of a 8th possible state.</typeparam>
    /// <typeparam name="T9">Type of a 9th possible state.</typeparam>
    /// <typeparam name="T10">Type of a 10th possible state.</typeparam>
    /// <typeparam name="T11">Type of a 11th possible state.</typeparam>
    /// <typeparam name="T12">Type of a 12th possible state.</typeparam>
    /// <typeparam name="T13">Type of a 13th possible state.</typeparam>
    /// <typeparam name="T14">Type of a 14th possible state.</typeparam>
    /// <typeparam name="T15">Type of a 15th possible state.</typeparam>
    /// <typeparam name="T16">Type of a 16th possible state.</typeparam>
    /// <typeparam name="T17">Type of a 17th possible state.</typeparam>
    /// <typeparam name="T18">Type of a 18th possible state.</typeparam>
    /// <typeparam name="T19">Type of a 19th possible state.</typeparam>
    /// <typeparam name="T20">Type of a 20th possible state.</typeparam>
    /// <typeparam name="T21">Type of a 21st possible state.</typeparam>
    /// <typeparam name="T22">Type of a 22nd possible state.</typeparam>
    /// <typeparam name="T23">Type of a 23rd possible state.</typeparam>
    /// <typeparam name="T24">Type of a 24th possible state.</typeparam>
    /// <typeparam name="T25">Type of a 25th possible state.</typeparam>
    /// <typeparam name="T26">Type of a 26th possible state.</typeparam>
    /// <typeparam name="T27">Type of a 27th possible state.</typeparam>
    /// <typeparam name="T28">Type of a 28th possible state.</typeparam>
    public struct MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
    {
        private readonly object _state;
        private readonly byte _selectedTypeIndex;

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer.
        /// </summary>
        /// <param name="observer1">Observer for the 1st state.</param>
        /// <param name="observer2">Observer for the 2nd state.</param>
        /// <param name="observer3">Observer for the 3rd state.</param>
        /// <param name="observer4">Observer for the 4th state.</param>
        /// <param name="observer5">Observer for the 5th state.</param>
        /// <param name="observer6">Observer for the 6th state.</param>
        /// <param name="observer7">Observer for the 7th state.</param>
        /// <param name="observer8">Observer for the 8th state.</param>
        /// <param name="observer9">Observer for the 9th state.</param>
        /// <param name="observer10">Observer for the 10th state.</param>
        /// <param name="observer11">Observer for the 11th state.</param>
        /// <param name="observer12">Observer for the 12th state.</param>
        /// <param name="observer13">Observer for the 13th state.</param>
        /// <param name="observer14">Observer for the 14th state.</param>
        /// <param name="observer15">Observer for the 15th state.</param>
        /// <param name="observer16">Observer for the 16th state.</param>
        /// <param name="observer17">Observer for the 17th state.</param>
        /// <param name="observer18">Observer for the 18th state.</param>
        /// <param name="observer19">Observer for the 19th state.</param>
        /// <param name="observer20">Observer for the 20th state.</param>
        /// <param name="observer21">Observer for the 21st state.</param>
        /// <param name="observer22">Observer for the 22nd state.</param>
        /// <param name="observer23">Observer for the 23rd state.</param>
        /// <param name="observer24">Observer for the 24th state.</param>
        /// <param name="observer25">Observer for the 25th state.</param>
        /// <param name="observer26">Observer for the 26th state.</param>
        /// <param name="observer27">Observer for the 27th state.</param>
        /// <param name="observer28">Observer for the 28th state.</param>
        /// <param name="nullObserver">Observer when the current state is null</param>
        public void Observe(Action<T1> observer1, Action<T2> observer2, Action<T3> observer3, Action<T4> observer4, Action<T5> observer5, Action<T6> observer6, Action<T7> observer7, Action<T8> observer8, Action<T9> observer9, Action<T10> observer10, Action<T11> observer11, Action<T12> observer12, Action<T13> observer13, Action<T14> observer14, Action<T15> observer15, Action<T16> observer16, Action<T17> observer17, Action<T18> observer18, Action<T19> observer19, Action<T20> observer20, Action<T21> observer21, Action<T22> observer22, Action<T23> observer23, Action<T24> observer24, Action<T25> observer25, Action<T26> observer26, Action<T27> observer27, Action<T28> observer28, Action nullObserver)
        {

            switch (_selectedTypeIndex)
            {
                case 1:
                    var state1 = (T1)_state;
                    observer1(state1);
                    break;
                case 2:
                    var state2 = (T2)_state;
                    observer2(state2);
                    break;
                case 3:
                    var state3 = (T3)_state;
                    observer3(state3);
                    break;
                case 4:
                    var state4 = (T4)_state;
                    observer4(state4);
                    break;
                case 5:
                    var state5 = (T5)_state;
                    observer5(state5);
                    break;
                case 6:
                    var state6 = (T6)_state;
                    observer6(state6);
                    break;
                case 7:
                    var state7 = (T7)_state;
                    observer7(state7);
                    break;
                case 8:
                    var state8 = (T8)_state;
                    observer8(state8);
                    break;
                case 9:
                    var state9 = (T9)_state;
                    observer9(state9);
                    break;
                case 10:
                    var state10 = (T10)_state;
                    observer10(state10);
                    break;
                case 11:
                    var state11 = (T11)_state;
                    observer11(state11);
                    break;
                case 12:
                    var state12 = (T12)_state;
                    observer12(state12);
                    break;
                case 13:
                    var state13 = (T13)_state;
                    observer13(state13);
                    break;
                case 14:
                    var state14 = (T14)_state;
                    observer14(state14);
                    break;
                case 15:
                    var state15 = (T15)_state;
                    observer15(state15);
                    break;
                case 16:
                    var state16 = (T16)_state;
                    observer16(state16);
                    break;
                case 17:
                    var state17 = (T17)_state;
                    observer17(state17);
                    break;
                case 18:
                    var state18 = (T18)_state;
                    observer18(state18);
                    break;
                case 19:
                    var state19 = (T19)_state;
                    observer19(state19);
                    break;
                case 20:
                    var state20 = (T20)_state;
                    observer20(state20);
                    break;
                case 21:
                    var state21 = (T21)_state;
                    observer21(state21);
                    break;
                case 22:
                    var state22 = (T22)_state;
                    observer22(state22);
                    break;
                case 23:
                    var state23 = (T23)_state;
                    observer23(state23);
                    break;
                case 24:
                    var state24 = (T24)_state;
                    observer24(state24);
                    break;
                case 25:
                    var state25 = (T25)_state;
                    observer25(state25);
                    break;
                case 26:
                    var state26 = (T26)_state;
                    observer26(state26);
                    break;
                case 27:
                    var state27 = (T27)_state;
                    observer27(state27);
                    break;
                case 28:
                    var state28 = (T28)_state;
                    observer28(state28);
                    break;
                case 0:
                    nullObserver();
                    break;
                default:
                    throw new InvalidOperationException("Cannot determine the method state.");
            }
        }

        /// <summary>
        /// This method lets the caller observe the current state asynchronously by calling respective state observer.
        /// </summary>
        /// <param name="observer1">Asynchronous observer for the 1st state.</param>
        /// <param name="observer2">Asynchronous observer for the 2nd state.</param>
        /// <param name="observer3">Asynchronous observer for the 3rd state.</param>
        /// <param name="observer4">Asynchronous observer for the 4th state.</param>
        /// <param name="observer5">Asynchronous observer for the 5th state.</param>
        /// <param name="observer6">Asynchronous observer for the 6th state.</param>
        /// <param name="observer7">Asynchronous observer for the 7th state.</param>
        /// <param name="observer8">Asynchronous observer for the 8th state.</param>
        /// <param name="observer9">Asynchronous observer for the 9th state.</param>
        /// <param name="observer10">Asynchronous observer for the 10th state.</param>
        /// <param name="observer11">Asynchronous observer for the 11th state.</param>
        /// <param name="observer12">Asynchronous observer for the 12th state.</param>
        /// <param name="observer13">Asynchronous observer for the 13th state.</param>
        /// <param name="observer14">Asynchronous observer for the 14th state.</param>
        /// <param name="observer15">Asynchronous observer for the 15th state.</param>
        /// <param name="observer16">Asynchronous observer for the 16th state.</param>
        /// <param name="observer17">Asynchronous observer for the 17th state.</param>
        /// <param name="observer18">Asynchronous observer for the 18th state.</param>
        /// <param name="observer19">Asynchronous observer for the 19th state.</param>
        /// <param name="observer20">Asynchronous observer for the 20th state.</param>
        /// <param name="observer21">Asynchronous observer for the 21st state.</param>
        /// <param name="observer22">Asynchronous observer for the 22nd state.</param>
        /// <param name="observer23">Asynchronous observer for the 23rd state.</param>
        /// <param name="observer24">Asynchronous observer for the 24th state.</param>
        /// <param name="observer25">Asynchronous observer for the 25th state.</param>
        /// <param name="observer26">Asynchronous observer for the 26th state.</param>
        /// <param name="observer27">Asynchronous observer for the 27th state.</param>
        /// <param name="observer28">Asynchronous observer for the 28th state.</param>
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task ObserveAsync(Func<T1, Task> observer1, Func<T2, Task> observer2, Func<T3, Task> observer3, Func<T4, Task> observer4, Func<T5, Task> observer5, Func<T6, Task> observer6, Func<T7, Task> observer7, Func<T8, Task> observer8, Func<T9, Task> observer9, Func<T10, Task> observer10, Func<T11, Task> observer11, Func<T12, Task> observer12, Func<T13, Task> observer13, Func<T14, Task> observer14, Func<T15, Task> observer15, Func<T16, Task> observer16, Func<T17, Task> observer17, Func<T18, Task> observer18, Func<T19, Task> observer19, Func<T20, Task> observer20, Func<T21, Task> observer21, Func<T22, Task> observer22, Func<T23, Task> observer23, Func<T24, Task> observer24, Func<T25, Task> observer25, Func<T26, Task> observer26, Func<T27, Task> observer27, Func<T28, Task> observer28, Func<Task> nullObserver)
        {
            return Observe(observer1, observer2, observer3, observer4, observer5, observer6, observer7, observer8, observer9, observer10, observer11, observer12, observer13, observer14, observer15, observer16, observer17, observer18, observer19, observer20, observer21, observer22, observer23, observer24, observer25, observer26, observer27, observer28, nullObserver);
        }

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer and returns an observation result.
        /// </summary>
        /// <typeparam name="TResult">Type of observation result.</typeparam>
        /// <param name="observer1">Observer for the 1st state.</param>
        /// <param name="observer2">Observer for the 2nd state.</param>
        /// <param name="observer3">Observer for the 3rd state.</param>
        /// <param name="observer4">Observer for the 4th state.</param>
        /// <param name="observer5">Observer for the 5th state.</param>
        /// <param name="observer6">Observer for the 6th state.</param>
        /// <param name="observer7">Observer for the 7th state.</param>
        /// <param name="observer8">Observer for the 8th state.</param>
        /// <param name="observer9">Observer for the 9th state.</param>
        /// <param name="observer10">Observer for the 10th state.</param>
        /// <param name="observer11">Observer for the 11th state.</param>
        /// <param name="observer12">Observer for the 12th state.</param>
        /// <param name="observer13">Observer for the 13th state.</param>
        /// <param name="observer14">Observer for the 14th state.</param>
        /// <param name="observer15">Observer for the 15th state.</param>
        /// <param name="observer16">Observer for the 16th state.</param>
        /// <param name="observer17">Observer for the 17th state.</param>
        /// <param name="observer18">Observer for the 18th state.</param>
        /// <param name="observer19">Observer for the 19th state.</param>
        /// <param name="observer20">Observer for the 20th state.</param>
        /// <param name="observer21">Observer for the 21st state.</param>
        /// <param name="observer22">Observer for the 22nd state.</param>
        /// <param name="observer23">Observer for the 23rd state.</param>
        /// <param name="observer24">Observer for the 24th state.</param>
        /// <param name="observer25">Observer for the 25th state.</param>
        /// <param name="observer26">Observer for the 26th state.</param>
        /// <param name="observer27">Observer for the 27th state.</param>
        /// <param name="observer28">Observer for the 28th state.</param>
        /// <param name="nullObserver">Observer when the current state is null</param>
        /// <returns>Observation result.</returns>
        public TResult Observe<TResult>(Func<T1, TResult> observer1, Func<T2, TResult> observer2, Func<T3, TResult> observer3, Func<T4, TResult> observer4, Func<T5, TResult> observer5, Func<T6, TResult> observer6, Func<T7, TResult> observer7, Func<T8, TResult> observer8, Func<T9, TResult> observer9, Func<T10, TResult> observer10, Func<T11, TResult> observer11, Func<T12, TResult> observer12, Func<T13, TResult> observer13, Func<T14, TResult> observer14, Func<T15, TResult> observer15, Func<T16, TResult> observer16, Func<T17, TResult> observer17, Func<T18, TResult> observer18, Func<T19, TResult> observer19, Func<T20, TResult> observer20, Func<T21, TResult> observer21, Func<T22, TResult> observer22, Func<T23, TResult> observer23, Func<T24, TResult> observer24, Func<T25, TResult> observer25, Func<T26, TResult> observer26, Func<T27, TResult> observer27, Func<T28, TResult> observer28, Func<TResult> nullObserver)
        {
            switch (_selectedTypeIndex)
            {
                case 1:
                    var state1 = (T1)_state;
                    return observer1(state1);
                case 2:
                    var state2 = (T2)_state;
                    return observer2(state2);
                case 3:
                    var state3 = (T3)_state;
                    return observer3(state3);
                case 4:
                    var state4 = (T4)_state;
                    return observer4(state4);
                case 5:
                    var state5 = (T5)_state;
                    return observer5(state5);
                case 6:
                    var state6 = (T6)_state;
                    return observer6(state6);
                case 7:
                    var state7 = (T7)_state;
                    return observer7(state7);
                case 8:
                    var state8 = (T8)_state;
                    return observer8(state8);
                case 9:
                    var state9 = (T9)_state;
                    return observer9(state9);
                case 10:
                    var state10 = (T10)_state;
                    return observer10(state10);
                case 11:
                    var state11 = (T11)_state;
                    return observer11(state11);
                case 12:
                    var state12 = (T12)_state;
                    return observer12(state12);
                case 13:
                    var state13 = (T13)_state;
                    return observer13(state13);
                case 14:
                    var state14 = (T14)_state;
                    return observer14(state14);
                case 15:
                    var state15 = (T15)_state;
                    return observer15(state15);
                case 16:
                    var state16 = (T16)_state;
                    return observer16(state16);
                case 17:
                    var state17 = (T17)_state;
                    return observer17(state17);
                case 18:
                    var state18 = (T18)_state;
                    return observer18(state18);
                case 19:
                    var state19 = (T19)_state;
                    return observer19(state19);
                case 20:
                    var state20 = (T20)_state;
                    return observer20(state20);
                case 21:
                    var state21 = (T21)_state;
                    return observer21(state21);
                case 22:
                    var state22 = (T22)_state;
                    return observer22(state22);
                case 23:
                    var state23 = (T23)_state;
                    return observer23(state23);
                case 24:
                    var state24 = (T24)_state;
                    return observer24(state24);
                case 25:
                    var state25 = (T25)_state;
                    return observer25(state25);
                case 26:
                    var state26 = (T26)_state;
                    return observer26(state26);
                case 27:
                    var state27 = (T27)_state;
                    return observer27(state27);
                case 28:
                    var state28 = (T28)_state;
                    return observer28(state28);
                case 0:
                    return nullObserver();
                default:
                    throw new InvalidOperationException("Cannot determine the method state.");
            }
        }

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer and returns an observation result asynchronously.
        /// </summary>
        /// <typeparam name="TResult">Type of observation result.</typeparam>
        /// <param name="observer1">Asynchronous observer for the 1st state.</param>
        /// <param name="observer2">Asynchronous observer for the 2nd state.</param>
        /// <param name="observer3">Asynchronous observer for the 3rd state.</param>
        /// <param name="observer4">Asynchronous observer for the 4th state.</param>
        /// <param name="observer5">Asynchronous observer for the 5th state.</param>
        /// <param name="observer6">Asynchronous observer for the 6th state.</param>
        /// <param name="observer7">Asynchronous observer for the 7th state.</param>
        /// <param name="observer8">Asynchronous observer for the 8th state.</param>
        /// <param name="observer9">Asynchronous observer for the 9th state.</param>
        /// <param name="observer10">Asynchronous observer for the 10th state.</param>
        /// <param name="observer11">Asynchronous observer for the 11th state.</param>
        /// <param name="observer12">Asynchronous observer for the 12th state.</param>
        /// <param name="observer13">Asynchronous observer for the 13th state.</param>
        /// <param name="observer14">Asynchronous observer for the 14th state.</param>
        /// <param name="observer15">Asynchronous observer for the 15th state.</param>
        /// <param name="observer16">Asynchronous observer for the 16th state.</param>
        /// <param name="observer17">Asynchronous observer for the 17th state.</param>
        /// <param name="observer18">Asynchronous observer for the 18th state.</param>
        /// <param name="observer19">Asynchronous observer for the 19th state.</param>
        /// <param name="observer20">Asynchronous observer for the 20th state.</param>
        /// <param name="observer21">Asynchronous observer for the 21st state.</param>
        /// <param name="observer22">Asynchronous observer for the 22nd state.</param>
        /// <param name="observer23">Asynchronous observer for the 23rd state.</param>
        /// <param name="observer24">Asynchronous observer for the 24th state.</param>
        /// <param name="observer25">Asynchronous observer for the 25th state.</param>
        /// <param name="observer26">Asynchronous observer for the 26th state.</param>
        /// <param name="observer27">Asynchronous observer for the 27th state.</param>
        /// <param name="observer28">Asynchronous observer for the 28th state.</param>
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task<TResult> ObserveAsync<TResult>(Func<T1, Task<TResult>> observer1, Func<T2, Task<TResult>> observer2, Func<T3, Task<TResult>> observer3, Func<T4, Task<TResult>> observer4, Func<T5, Task<TResult>> observer5, Func<T6, Task<TResult>> observer6, Func<T7, Task<TResult>> observer7, Func<T8, Task<TResult>> observer8, Func<T9, Task<TResult>> observer9, Func<T10, Task<TResult>> observer10, Func<T11, Task<TResult>> observer11, Func<T12, Task<TResult>> observer12, Func<T13, Task<TResult>> observer13, Func<T14, Task<TResult>> observer14, Func<T15, Task<TResult>> observer15, Func<T16, Task<TResult>> observer16, Func<T17, Task<TResult>> observer17, Func<T18, Task<TResult>> observer18, Func<T19, Task<TResult>> observer19, Func<T20, Task<TResult>> observer20, Func<T21, Task<TResult>> observer21, Func<T22, Task<TResult>> observer22, Func<T23, Task<TResult>> observer23, Func<T24, Task<TResult>> observer24, Func<T25, Task<TResult>> observer25, Func<T26, Task<TResult>> observer26, Func<T27, Task<TResult>> observer27, Func<T28, Task<TResult>> observer28, Func<Task<TResult>> nullObserver)
        {
            return Observe(observer1, observer2, observer3, observer4, observer5, observer6, observer7, observer8, observer9, observer10, observer11, observer12, observer13, observer14, observer15, observer16, observer17, observer18, observer19, observer20, observer21, observer22, observer23, observer24, observer25, observer26, observer27, observer28, nullObserver);
        }

        /// <summary>
        /// Constructs the 1st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T1 state)
        {
            _state = state;
            _selectedTypeIndex = 1;
        }

        /// <summary>
        /// Constructs the 2nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T2 state)
        {
            _state = state;
            _selectedTypeIndex = 2;
        }

        /// <summary>
        /// Constructs the 3rd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T3 state)
        {
            _state = state;
            _selectedTypeIndex = 3;
        }

        /// <summary>
        /// Constructs the 4th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T4 state)
        {
            _state = state;
            _selectedTypeIndex = 4;
        }

        /// <summary>
        /// Constructs the 5th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T5 state)
        {
            _state = state;
            _selectedTypeIndex = 5;
        }

        /// <summary>
        /// Constructs the 6th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T6 state)
        {
            _state = state;
            _selectedTypeIndex = 6;
        }

        /// <summary>
        /// Constructs the 7th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T7 state)
        {
            _state = state;
            _selectedTypeIndex = 7;
        }

        /// <summary>
        /// Constructs the 8th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T8 state)
        {
            _state = state;
            _selectedTypeIndex = 8;
        }

        /// <summary>
        /// Constructs the 9th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T9 state)
        {
            _state = state;
            _selectedTypeIndex = 9;
        }

        /// <summary>
        /// Constructs the 10th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T10 state)
        {
            _state = state;
            _selectedTypeIndex = 10;
        }

        /// <summary>
        /// Constructs the 11th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T11 state)
        {
            _state = state;
            _selectedTypeIndex = 11;
        }

        /// <summary>
        /// Constructs the 12th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T12 state)
        {
            _state = state;
            _selectedTypeIndex = 12;
        }

        /// <summary>
        /// Constructs the 13th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T13 state)
        {
            _state = state;
            _selectedTypeIndex = 13;
        }

        /// <summary>
        /// Constructs the 14th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T14 state)
        {
            _state = state;
            _selectedTypeIndex = 14;
        }

        /// <summary>
        /// Constructs the 15th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T15 state)
        {
            _state = state;
            _selectedTypeIndex = 15;
        }

        /// <summary>
        /// Constructs the 16th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T16 state)
        {
            _state = state;
            _selectedTypeIndex = 16;
        }

        /// <summary>
        /// Constructs the 17th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T17 state)
        {
            _state = state;
            _selectedTypeIndex = 17;
        }

        /// <summary>
        /// Constructs the 18th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T18 state)
        {
            _state = state;
            _selectedTypeIndex = 18;
        }

        /// <summary>
        /// Constructs the 19th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T19 state)
        {
            _state = state;
            _selectedTypeIndex = 19;
        }

        /// <summary>
        /// Constructs the 20th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T20 state)
        {
            _state = state;
            _selectedTypeIndex = 20;
        }

        /// <summary>
        /// Constructs the 21st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T21 state)
        {
            _state = state;
            _selectedTypeIndex = 21;
        }

        /// <summary>
        /// Constructs the 22nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T22 state)
        {
            _state = state;
            _selectedTypeIndex = 22;
        }

        /// <summary>
        /// Constructs the 23rd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T23 state)
        {
            _state = state;
            _selectedTypeIndex = 23;
        }

        /// <summary>
        /// Constructs the 24th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T24 state)
        {
            _state = state;
            _selectedTypeIndex = 24;
        }

        /// <summary>
        /// Constructs the 25th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T25 state)
        {
            _state = state;
            _selectedTypeIndex = 25;
        }

        /// <summary>
        /// Constructs the 26th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T26 state)
        {
            _state = state;
            _selectedTypeIndex = 26;
        }

        /// <summary>
        /// Constructs the 27th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T27 state)
        {
            _state = state;
            _selectedTypeIndex = 27;
        }

        /// <summary>
        /// Constructs the 28th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        private MethodState(T28 state)
        {
            _state = state;
            _selectedTypeIndex = 28;
        }

        /// <summary>
        /// Implicit cast for the 1st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 2nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T2 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 3rd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T3 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 4th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T4 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 5th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T5 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 6th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T6 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 7th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T7 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 8th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T8 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 9th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T9 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 10th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T10 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 11th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T11 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 12th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T12 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 13th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T13 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 14th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T14 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 15th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T15 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 16th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T16 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 17th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T17 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 18th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T18 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 19th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T19 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 20th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T20 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 21st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T21 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 22nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T22 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 23rd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T23 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 24th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T24 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 25th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T25 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 26th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T26 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 27th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T27 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }

        /// <summary>
        /// Implicit cast for the 28th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T28 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(state);
        }
    }
}