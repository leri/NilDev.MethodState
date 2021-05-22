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
    public struct MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
        /// <param name="nullObserver">Observer when the current state is null</param>
        public void Observe(Action<T1> observer1, Action<T2> observer2, Action<T3> observer3, Action<T4> observer4, Action<T5> observer5, Action<T6> observer6, Action<T7> observer7, Action<T8> observer8, Action<T9> observer9, Action<T10> observer10, Action<T11> observer11, Action<T12> observer12, Action<T13> observer13, Action nullObserver)
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
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task ObserveAsync(Func<T1, Task> observer1, Func<T2, Task> observer2, Func<T3, Task> observer3, Func<T4, Task> observer4, Func<T5, Task> observer5, Func<T6, Task> observer6, Func<T7, Task> observer7, Func<T8, Task> observer8, Func<T9, Task> observer9, Func<T10, Task> observer10, Func<T11, Task> observer11, Func<T12, Task> observer12, Func<T13, Task> observer13, Func<Task> nullObserver)
        {
            return Observe(observer1, observer2, observer3, observer4, observer5, observer6, observer7, observer8, observer9, observer10, observer11, observer12, observer13, nullObserver);
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
        /// <param name="nullObserver">Observer when the current state is null</param>
        /// <returns>Observation result.</returns>
        public TResult Observe<TResult>(Func<T1, TResult> observer1, Func<T2, TResult> observer2, Func<T3, TResult> observer3, Func<T4, TResult> observer4, Func<T5, TResult> observer5, Func<T6, TResult> observer6, Func<T7, TResult> observer7, Func<T8, TResult> observer8, Func<T9, TResult> observer9, Func<T10, TResult> observer10, Func<T11, TResult> observer11, Func<T12, TResult> observer12, Func<T13, TResult> observer13, Func<TResult> nullObserver)
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
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task<TResult> ObserveAsync<TResult>(Func<T1, Task<TResult>> observer1, Func<T2, Task<TResult>> observer2, Func<T3, Task<TResult>> observer3, Func<T4, Task<TResult>> observer4, Func<T5, Task<TResult>> observer5, Func<T6, Task<TResult>> observer6, Func<T7, Task<TResult>> observer7, Func<T8, Task<TResult>> observer8, Func<T9, Task<TResult>> observer9, Func<T10, Task<TResult>> observer10, Func<T11, Task<TResult>> observer11, Func<T12, Task<TResult>> observer12, Func<T13, Task<TResult>> observer13, Func<Task<TResult>> nullObserver)
        {
            return Observe(observer1, observer2, observer3, observer4, observer5, observer6, observer7, observer8, observer9, observer10, observer11, observer12, observer13, nullObserver);
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
        /// Implicit cast for the 1st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 2nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 3rd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 4th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 5th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 6th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 7th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 8th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 9th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 10th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 11th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 12th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }

        /// <summary>
        /// Implicit cast for the 13th state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
            }

            return new MethodState<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(state);
        }
    }
}