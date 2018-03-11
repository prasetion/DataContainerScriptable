using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class FlexibleUIButton : FlexibleUI {

	Image _image;
	Button _button;

	protected override void OnSkinUI(){
		base.OnSkinUI();

		_image = GetComponent<Image>();
		_button = GetComponent<Button>();

		_button.transition = Selectable.Transition.SpriteSwap;
		_button.targetGraphic = _image;

		_image.sprite = skinData.buttonSprite;
		_image.type = Image.Type.Sliced;
		_button.spriteState = skinData.buttonSpriteState;

	}

}
