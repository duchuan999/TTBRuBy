module Danhmuc
  class DmphieusController < PageController
    helper_method :sort_column, :sort_direction
    respond_to :html, :js

    def index
      @dmphieus = Dmphieu.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    end

    def show
      @dmphieu = Dmphieu.find(params[:id])
    end

    def edit
      @dmphieu = Dmphieu.find(params[:id])
    end

    def update
      @dmphieus = Dmphieu.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

      @dmphieu = Dmphieu.find(params[:id])
      @dmphieu.update_attributes(dmphieu_params)
    end

    def new
      @dmphieu = Dmphieu.new
    end

    def create
      @dmphieus = Dmphieu.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmphieu = Dmphieu.create(dmphieu_params)
    end

    def delete
      @dmphieu = Dmphieu.find(params[:dmphieu_id])
    end

    def destroy
      @dmphieus = Dmphieu.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmphieu = Dmphieu.find(params[:id])
      @dmphieu.destroy
    end

    private
    def dmphieu_params
      params.require(:dmphieu).permit(:stt, :ten, :dmloaiphieu_id)
    end

    def sort_column
      Dmphieu.column_names.include?(params[:sort]) ? params[:sort] : "ten"
    end

    def sort_direction
      %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
    end
  end
end