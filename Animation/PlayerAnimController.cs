// using System;
// using System.Collections.Generic;
// using UnityEngine;
// using LifeContent;
// using Player;

// namespace Anim{

//     public class PlayerAnimController : AnimationController<PlayerState> {
        
//         AnimInfo<PlayerState> moveInfo;
//         AnimInfo<PlayerState> exitInfo;

//         protected override void Start() {
//             base.Start();

//             moveInfo = animationState[PlayerState.Move];
//             exitInfo = animationState[PlayerState.Exit];
//         }

//         // public static PlayerState GetLifeTypeToPlayerState(Enum life){
//         //     PlayerState state = PlayerState.Exit;

//         //     switch(life){
//         //         case WoodcuttingType.Tree:
//         //             // 현재 애니메이션이  존재하지 않음
//         //             break;
//         //         case WoodcuttingType.FruitTree:
//         //             state = PlayerState.Woodcutting_Fruit;
//         //             break;
//         //         case WoodcuttingType.FlowerTree:
//         //             state = PlayerState.Woodcutting_Flower;
//         //             break;
//         //         case FishingType.Rod:
//         //             state = PlayerState.Fishing_Rod_Start;
//         //             break;
//         //         case FishingType.Net:
//         //             // 현재 애니메이션이  존재하지 않음
//         //             break;
//         //         case FarmingType.GroundPlant:
//         //             state = PlayerState.Farming_Ground;
//         //             break;
//         //         case FarmingType.UnderGroundPlant:
//         //             state = PlayerState.Farming_Underground;
//         //             break;
//         //         case LivestockType.Meat:
//         //             state = PlayerState.Livestock_Meat;
//         //             break;
//         //         case LivestockType.Leather:
//         //             state = PlayerState.Livestock_Leather;
//         //             break;
//         //         case LivestockType.ByProduct:
//         //             state = PlayerState.Livestock_Milk;
//         //             break;
//         //     }

//         //     return state;
//         // }

//         // 플레이어의 상태를 변환시키는 함수
//         public override void ChangeState(PlayerState next_state, object value = null){
//             if (current_state != next_state){       // 현재 상태가 다음 상태와 다르면 상태 변환
//                 current_state = next_state;
                
//                 // exit 미지정 시 종료
//                 if (exitInfo == null){
//                     Debug.LogError("Exit State 미지정 정의 필요");
//                     return;
//                 }

//                 // 플레이어 현재 애니메이션 종료
//                 parameterActions[exitInfo.parmeterType](exitInfo.stateName, value);

//                 // 플레이어 다음 애니메이션 상태 지정 후 실행
//                 AnimInfo<PlayerState> next_info = animationState[next_state];
//                 parameterActions[next_info.parmeterType](next_info.stateName, value);
//             }
//             else{
//                 // 현재 상태가 다음 상태와 같을 경우 아무것도 하지 않음
//                 return;
//             }
//         }

//         // 플레이어 움직일때마다 이 함수 실행 필요
//         public void UpdateMove(Vector3 value){
//             if (current_state != PlayerState.Move){
//                 current_state = PlayerState.Move;
//             }
//             parameterActions[moveInfo.parmeterType](moveInfo.stateName, value.normalized.magnitude);
//         }
//     }
// }