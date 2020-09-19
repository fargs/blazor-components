﻿//Task based implementation it does not work with Server Side Blazor

/*
@using System.Threading
@using System.Threading.Tasks

<input @bind-value=InternalValue @bind-value:event="oninput" @attributes=AllOtherAttributes />

@code
{

	private string _value;
private string InternalValue
{
	get => _value;
	set
	{
		_value = value;
		OnValueCahnged();
	}
}

[Parameter] public string Value { get; set; }
[Parameter] public int MinLength { get; set; } = 0;
[Parameter] public int Delay { get; set; } = 300;
[Parameter] public bool DiagEnabled { get; set; } = false;

[Parameter(CaptureUnmatchedValues = true)]
public Dictionary<string, object> AllOtherAttributes { get; set; }

[Parameter] public EventCallback<string> ValueChanged { get; set; }


private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
private CancellationToken _cancellationToken;

protected override void OnInitialized()
{
	_value = Value;

	WriteDiag($"Initialized with Value: '{_value}', Task Delay: '{Delay}' ms, Min sting Length: '{MinLength}'.");
}

private void OnValueCahnged()
{
	InvokeAsync(async () =>
	{
		_cancellationTokenSource.Cancel(false);
		_cancellationTokenSource = new CancellationTokenSource();
		_cancellationToken = _cancellationTokenSource.Token;

		await Task.Delay(Delay, _cancellationToken).ContinueWith(async task =>
		{
			WriteDiag($"Delay exceeded: {Delay} ms, Value: '{InternalValue}', Task IsCanceled: {task.IsCanceled}");

			if (!task.IsCanceled && InternalValue?.Length >= MinLength)
			{
				WriteDiag($"Invoke ValueChanged event with: '{InternalValue}'");

				Value = InternalValue;
				await ValueChanged.InvokeAsync(Value);
				StateHasChanged();
			}
		}, _cancellationToken);
	});
}

private void WriteDiag(string message)
{
	if (DiagEnabled)
	{
		Console.WriteLine($"Component {nameof(DebounceInput2)}: {message}");
		System.Diagnostics.Debug.Write($"Component {nameof(DebounceInput2)}: {message}");
	}
}
}*/