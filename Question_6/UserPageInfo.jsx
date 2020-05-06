// Блок информации о текущем пользователе
// Состоит из:
// Блок текущего имени
// Блок информации о пользователе
// Блок количественных показателей о пользователе
class UserPageInfo {
    render() {
        return (<div>
            <UserPageCurrentName />
            <UserPageInfo />
            <UserPagestatistics />
        </div>);
    }
}
