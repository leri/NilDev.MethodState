using System;
using System.Threading.Tasks;

namespace NilDev.MethodState
{
    /// <summary>
    /// Describes the possible states which can be returned by a method and gives the possibility to observe it when required.
    /// </summary>
    /// <typeparam name="T1">Type of a 1st possible state.</typeparam>
    /// <typeparam name="T2">Type of a 2nd possible state.</typeparam>
    public struct MethodState<T1, T2>
    {
        private readonly object _state;
        private readonly byte _selectedTypeIndex;

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer.
        /// </summary>
        /// <param name="observer1">Observer for the 1st state.</param>
        /// <param name="observer2">Observer for the 2nd state.</param>
        /// <param name="nullObserver">Observer when the current state is null</param>
        public void Observe(Action<T1> observer1, Action<T2> observer2, Action nullObserver)
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
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task ObserveAsync(Func<T1, Task> observer1, Func<T2, Task> observer2, Func<Task> nullObserver)
        {
            return Observe(observer1, observer2, nullObserver);
        }

        /// <summary>
        /// This method lets the caller observe the current state by calling respective state observer and returns an observation result.
        /// </summary>
        /// <typeparam name="TResult">Type of observation result.</typeparam>
        /// <param name="observer1">Observer for the 1st state.</param>
        /// <param name="observer2">Observer for the 2nd state.</param>
        /// <param name="nullObserver">Observer when the current state is null</param>
        /// <returns>Observation result.</returns>
        public TResult Observe<TResult>(Func<T1, TResult> observer1, Func<T2, TResult> observer2, Func<TResult> nullObserver)
        {
            switch (_selectedTypeIndex)
            {
                case 1:
                    var state1 = (T1)_state;
                    return observer1(state1);
                case 2:
                    var state2 = (T2)_state;
                    return observer2(state2);
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
        /// <param name="nullObserver">Asynchronous observer when the current state is null</param>
        /// <returns>Task</returns>
        public Task<TResult> ObserveAsync<TResult>(Func<T1, Task<TResult>> observer1, Func<T2, Task<TResult>> observer2, Func<Task<TResult>> nullObserver)
        {
            return Observe(observer1, observer2, nullObserver);
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
        /// Implicit cast for the 1st state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2>(T1 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2>();
            }

            return new MethodState<T1, T2>(state);
        }

        /// <summary>
        /// Implicit cast for the 2nd state.
        /// </summary>
        /// <param name="state">Current state.</param>
        public static implicit operator MethodState<T1, T2>(T2 state)
        {
            if (state is null)
            {
                return new MethodState<T1, T2>();
            }

            return new MethodState<T1, T2>(state);
        }
    }
}