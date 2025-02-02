// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using Files.App.AppModels;
using Microsoft.UI.Xaml.Data;

namespace Files.App.ValueConverters
{
	internal sealed class ImageModelToImageConverter : IValueConverter
	{
		public object? Convert(object value, Type targetType, object parameter, string language)
		{
			if (value is BitmapImageModel bitmapImageModel)
				return bitmapImageModel.Image;

			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
