using AutoMapper;
using DotnetRpg.Dtos.Character;
using DotnetRpg.Dtos.Item;
using DotnetRpg.Dtos.Skill;
using DotnetRpg.Dtos.StatusEffect;

namespace DotnetRpg.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Character, GetCharacterDto>()
            .ForMember(
                dest => dest.EquippedWeapon,
                opt => opt.MapFrom(new EquippedWeaponResolver())
            )
            .ForMember(
                dest => dest.EquippedArmorPieces,
                opt => opt.MapFrom(new EquippedArmorPiecesResolver())
            )
            .ForMember(dest => dest.Strength, opt => opt.MapFrom(src => src.GetStrength()))
            .ForMember(dest => dest.Intelligence, opt => opt.MapFrom(src => src.GetIntelligence()))
            .ForMember(dest => dest.Stamina, opt => opt.MapFrom(src => src.GetStamina()))
            .ForMember(dest => dest.Spirit, opt => opt.MapFrom(src => src.GetSpirit()))
            .ForMember(dest => dest.Armor, opt => opt.MapFrom(src => src.GetArmor()))
            .ForMember(dest => dest.Resistance, opt => opt.MapFrom(src => src.GetResistance()))
            .ForMember(dest => dest.MaxEnergy, opt => opt.MapFrom(src => src.GetMaxEnergy()))
            .ForMember(dest => dest.MaxHitPoints, opt => opt.MapFrom(src => src.GetMaxHitPoints()));

        CreateMap<Character, GetCharacterListingDto>();
        CreateMap<AddCharacterDto, Character>();
        CreateMap<UpdateCharacterDto, Character>();

        CreateMap<SkillInstance, GetSkillInstanceDto>();
        CreateMap<Skill, GetSkillDto>();

        CreateMap<StatusEffectInstance, GetStatusEffectInstanceDto>();
        CreateMap<StatusEffect, GetStatusEffectDto>();

        CreateMap<Weapon, GetItemDto>();
        CreateMap<ArmorPiece, GetItemDto>();
    }
}
