﻿namespace Vanara.Pinvoke;

/// <summary>Provides a handle to an accelerator table.</summary>
[StructLayout(LayoutKind.Sequential)]
public partial struct HACCEL : IUserHandle
{
	private readonly IntPtr handle;

	/// <summary>Initializes a new instance of the <see cref="HACCEL"/> struct.</summary>
	/// <param name="preexistingHandle">An <see cref="IntPtr"/> object that represents the pre-existing handle to use.</param>
	public HACCEL(IntPtr preexistingHandle) => handle = preexistingHandle;

	/// <summary>Returns an invalid handle by instantiating a <see cref="HACCEL"/> object with <see cref="IntPtr.Zero"/>.</summary>
	public static HACCEL NULL => new(IntPtr.Zero);

	/// <summary>Gets a value indicating whether the handle is invalid.</summary>
	/// <value><see langword="true"/> if the handle is invalid; otherwise, <see langword="false"/>.</value>
	public readonly bool IsInvalid => handle == IntPtr.Zero || handle == new IntPtr(-1);

	/// <summary>Gets a value indicating whether this instance is a null handle.</summary>
	public readonly bool IsNull => handle == IntPtr.Zero;

	/// <summary>Performs an explicit conversion from <see cref="HACCEL"/> to <see cref="IntPtr"/>.</summary>
	/// <param name="h">The handle.</param>
	/// <returns>The result of the conversion.</returns>
	public static explicit operator IntPtr(HACCEL h) => h.handle;

	/// <summary>Performs an implicit conversion from <see cref="IntPtr"/> to <see cref="HACCEL"/>.</summary>
	/// <param name="h">The pointer to a handle.</param>
	/// <returns>The result of the conversion.</returns>
	public static implicit operator HACCEL(IntPtr h) => new(h);

	/// <summary>Implements the operator !=.</summary>
	/// <param name="h1">The first handle.</param>
	/// <param name="h2">The second handle.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(HACCEL h1, HACCEL h2) => !(h1 == h2);

	/// <summary>Implements the operator ==.</summary>
	/// <param name="h1">The first handle.</param>
	/// <param name="h2">The second handle.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(HACCEL h1, HACCEL h2) => h1.Equals(h2);

	/// <summary>Implements the operator !.</summary>
	/// <param name="h1">The handle.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !(HACCEL h1) => h1.IsNull;

#if !NETSTANDARD
	/// <summary>Implements the operator <see langword="true"/>.</summary>
	/// <param name="h">The value.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator true(HACCEL h) => !h.IsInvalid;

	/// <summary>Implements the operator <see langword="false"/>.</summary>
	/// <param name="h">The value.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator false(HACCEL h) => h.IsInvalid;
#endif

	/// <inheritdoc/>
	public readonly override bool Equals(object obj) => obj is HACCEL h && handle == h.handle;

	/// <inheritdoc/>
	public readonly override int GetHashCode() => handle.GetHashCode();

	/// <inheritdoc/>
	public readonly IntPtr DangerousGetHandle() => handle;
}