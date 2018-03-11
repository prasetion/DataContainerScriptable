using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class FlexibleUIButton : FlexibleUI {

	public enum ButtonType{
		Default,
		Confirm,
		Decline,
		Warning
	}

	Image _image;
	Image _icon;
	Button _button;

	public ButtonType buttonType;

	protected override void OnSkinUI(){
		base.OnSkinUI();

		_image = GetComponent<Image>();
		_icon = _image.GetComponentInChildren<Image>();
		_button = GetComponent<Button>();

		_button.transition = Selectable.Transition.SpriteSwap;
		_button.targetGraphic = _image;

		_image.sprite = skinData.buttonSprite;
		_image.type = Image.Type.Sliced;
		_button.spriteState = skinData.buttonSpriteState;


		switch(buttonType){

			case ButtonType.Default:
				_image.color = skinData.defaultColor;
				_icon.sprite = skinData.defaultIcon;
				break;

			case ButtonType.Confirm:
				_image.color = skinData.confirmColor;
				_icon.sprite = skinData.defaultIcon;
				break;

			case ButtonType.Decline:
				_image.color = skinData.declineColor;
				_icon.sprite = skinData.declineIcon;
				break;
			
			case ButtonType.Warning:
				_image.color = skinData.warningColor;
				_icon.sprite = skinData.warningIcon;
				break;
		}

	}

}
